using ML_TP034533.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ML_TP034533.ViewModel
{
    public class BookViewModel
    {
        public BookingModel bookModel { get; set; }

        public ScheduleModel scheduleModel { get; set; }

        public List<CustomerModel> customerModelList { get; set; }

    }
}