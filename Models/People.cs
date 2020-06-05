using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskProject.Models
{
    public class People
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [Required]
        public int MobileNumber { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
    }
}