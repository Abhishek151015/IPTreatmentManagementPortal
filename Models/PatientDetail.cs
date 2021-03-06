﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

namespace IPTreatmentManagementPortal.Models
{
    public class PatientDetail
    {   
        [Required]
        [DisplayName("Patient Name")]
        [StringLength(30, ErrorMessage = "Only 30 characters allowed")]
        public string PatientName { get; set; }
        
        [Required]
        [DisplayName("Age")]
        public int Age { get; set; }

        [Required]
        [DisplayName("Ailment")]
        public string Ailment { get; set; }
        [Required]
        [DisplayName("Package Name")]
        public Package Packages { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Treatment Commencement Date")]
        public DateTime Date { get; set; }

        
    }
    public enum Package
    {
        Package1=1,
        Package2=2
    }
}
