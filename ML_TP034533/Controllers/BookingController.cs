using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ML_TP034533.Models;
using ML_TP034533.ViewModel;

namespace ML_TP034533.Controllers
{
    public class BookingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Book
        public ActionResult Index()
        {           
            return View(db.Schedule.ToList());
        }

        // GET: Book/List/5
        public ActionResult List()
        {
            var book = db.Booking.Include(b => b.customerData).Include(b => b.scheduleData);
            return View(book);
        }

        // GET: Book/ViewOnlyList/5
        public ActionResult ViewOnlyList()
        {
            var book = db.Booking.Include(b => b.customerData).Include(b => b.scheduleData);
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create(int Id)
        {                       
            var bvm = new BookViewModel
            {
                scheduleModel = db.Schedule.SingleOrDefault(s => s.Id == Id),
                customerModelList = db.Customer.ToList()
            };

            return View(bvm);
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult addBooking(BookViewModel bookViewModel)
        {
            BookViewModel book = new BookViewModel
            {
                scheduleModel = db.Schedule.SingleOrDefault(s => s.Id == bookViewModel.scheduleModel.Id),
                customerModelList = db.Customer.ToList()
            };

            var booking1 = new BookingModel
            {
                customerModelId = bookViewModel.bookModel.customerModelId,
                ItemWeight = bookViewModel.bookModel.ItemWeight,
                ContainerAmount = bookViewModel.bookModel.ContainerAmount,
                scheduleModelId = bookViewModel.scheduleModel.Id

            };

            if (ModelState.IsValid)
            {
                db.Booking.Add(booking1);
                db.SaveChanges();
                return RedirectToAction("List");

            }
            else
            {
                return View("Create", book);
            }

        }

  
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
