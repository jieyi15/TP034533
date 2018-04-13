using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ML_TP034533.Models
{
    public class BookingModel
    {
        public int Id { get; set; }

       
        [Required]       
        [Display(Name = "Item Weight")]
        public int ItemWeight { get; set; }

        [Required]
        [Display(Name = "Container Amount")]
        public int ContainerAmount { get; set; }

        public CustomerModel customerData { get; set; }
        
        public int customerModelId { get; set; }

        public ScheduleModel scheduleData { get; set; }
      
        public int scheduleModelId { get; set; }
    }
}