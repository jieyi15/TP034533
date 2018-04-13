using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;

namespace ML_TP034533.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'.\s]{1,40}$", ErrorMessage = "Invalid Name")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]        
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string ContactNum { get; set; }

        
    }
}