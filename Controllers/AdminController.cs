using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IPTreatmentManagementPortal.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace IPTreatmentManagementPortal.Controllers
{
    
    public class AdminController : Controller
    {
       
     //   public static string token;
     
        private readonly AppDBContext _context;

        public AdminController(AppDBContext context)
        {
            _context = context;
        }
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AdminController));

        private List<IPTreatmentPackages> treatmentpackage = new List<IPTreatmentPackages>()
            {
                new IPTreatmentPackages
                {
                    AilmentCategory="Orthopaedics",
                    TreatmentPackageName="Package1",
                    TestDetails="OPT1, OPT2",
                    Cost=2500,
                    TreatmentDuration=4
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Orthopaedics",
                    TreatmentPackageName="Package2",
                    TestDetails="OPT3, OPT4",
                    Cost=3000,
                    TreatmentDuration=6
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Urology",
                    TreatmentPackageName="Package1",
                    TestDetails="UPT1, UPT2",
                    Cost=4000,
                    TreatmentDuration=4
                },
                new IPTreatmentPackages
                {
                    AilmentCategory="Urology",
                    TreatmentPackageName="Package2",
                    TestDetails="UPT3, UPT4",
                    Cost=5000,
                    TreatmentDuration=6
                }
             };
     
        public ActionResult Index(string name)
        {
         //     token = name;
            HttpContext.Session.SetString("JWToken", name);
            _log4net.Info("Admin logged in.");
            return RedirectToAction("Dashboard");
        }
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetPackages()
        {
            _log4net.Info("Returning the list of treatment packages.");
            return View(treatmentpackage);
        }
        [HttpGet]
        public ActionResult ChooseTreatmentPlan()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> ChooseTreatmentPlan(PatientDetail details)
        {
            if (ModelState.IsValid)
            {
                if (details.Date <= DateTime.Now)
                {
                    ViewBag.wrongdate = "Invalid date of commencement";
                    return View();
                }
                PatientRecords patientrecord = new PatientRecords();
                patientrecord.PatientName = details.PatientName;
                patientrecord.Age = details.Age;
                patientrecord.Ailment = details.Ailment;
                patientrecord.Package = details.Package;

                TreatmentPlan treatmentPlan = new TreatmentPlan();

                var json = JsonConvert.SerializeObject(details);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                using (var client = new HttpClient())
                {

                   //    client.BaseAddress = new Uri("http://localhost:52435/");
                    var token = HttpContext.Session.GetString("JWToken");
                    client.BaseAddress = new Uri("http://52.191.83.228/");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = new HttpResponseMessage();
                    response = client.PostAsync("api/FormulateTreatmentTimetable", data).Result;
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    treatmentPlan = JsonConvert.DeserializeObject<TreatmentPlan>(apiResponse);


                }
                patientrecord.Cost = treatmentPlan.Cost;
                patientrecord.Specialist = treatmentPlan.Specialist;

                _context.PatientRecords.Add(patientrecord);
                _context.SaveChanges();

                _log4net.Info("Mapping treatment plan according to patient details by invoking IPTreatment Microservice.");
                return RedirectToAction("ViewTreatmentPlan", treatmentPlan);
            }
            ViewBag.Message = "Please update the highlighted mandatory field(s)";
            return View();
        }

        [HttpGet]
        public ActionResult ViewTreatmentPlan(TreatmentPlan plan)
        {
            
            return View(plan);
        }

        public List<PatientRecords> patientlist = new List<PatientRecords>();
       [HttpGet]
        public ActionResult GetRecords()
        {
            
            patientlist = _context.PatientRecords.ToList();
            return View(patientlist);
        }
        static List<InsurerDetail> insurerDetails = new List<InsurerDetail>();
        [HttpGet]
        public async Task<ActionResult> GetInsuranceDetails(int id)
        {
            TempData["pid"] = id; 
      
            using (var client = new HttpClient())
            {
                var token = HttpContext.Session.GetString("JWToken");
                //      client.BaseAddress = new Uri("http://localhost:50459/");
                client.BaseAddress = new Uri("http://52.149.242.252/");
                client.DefaultRequestHeaders.Clear();
               client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = new HttpResponseMessage();
                response = client.GetAsync("api/InsuranceClaim/").Result;
                var data = response.Content.ReadAsAsync<IEnumerable<InsurerDetail>>().Result;
                foreach (var x in data)
                {
                    insurerDetails.Add(x);
                }
                _log4net.Info("Listing insurer details by invoking InsuranceClaim microservice.");
                return View(insurerDetails);
            }
        }
        [HttpGet]
        public ActionResult InitiateClaim(string insurer)
        {
         
            var record = _context.PatientRecords.Where(x => x.PatientId == Convert.ToInt32(TempData["pid"])).FirstOrDefault();
            var insurerdetail = insurerDetails.Where(x => x.InsurerName == insurer).FirstOrDefault();
            double limit = insurerdetail.InsuranceAmountLimit;

            InitiateClaim claim = new InitiateClaim();
            claim.PatientName = record.PatientName;
            claim.Ailment = record.Ailment;
            claim.TreatmentPackageName = record.Package.ToString();
            claim.InsurerName = insurer;
            claim.Cost = record.Cost;
            claim.InsuranceAmountLimit = limit;

            record.InsurerName = insurer;

            double balance;
          
            var json = JsonConvert.SerializeObject(claim);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                var token = HttpContext.Session.GetString("JWToken");
                // client.BaseAddress = new Uri("http://localhost:50459/");
                client.BaseAddress = new Uri("http://52.149.242.252/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = new HttpResponseMessage();
           
                  response = client.PostAsync("api/InsuranceClaim/", data).Result;
                if (response.IsSuccessStatusCode)
                {
                    balance = Convert.ToInt64(response.Content.ReadAsStringAsync().Result);
                   
                    record.Balance = balance;
                }
                _context.SaveChanges();
            }
          
            return RedirectToAction("GetRecords");
        }
        public IActionResult Error()
        {
            return View("Error");
        }

    }
}