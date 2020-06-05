using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskProject.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string CompanyName { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
    }
}