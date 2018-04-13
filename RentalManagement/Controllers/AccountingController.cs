using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentalManagement.Models;
using RentalManagement.CustomFilters;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace RentalManagement.Controllers
{
    [AuthLog(Roles = "Tenant")]
    public class AccountingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Accounting
        public ActionResult Index()
        {
            ViewBag.Message = "Accounting page.";

            var userID = User.Identity.GetUserId();

            if (!string.IsNullOrEmpty(userID))
            {
                var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(ApplicationDbContext.Create()));
                var currentUser = manager.FindById(User.Identity.GetUserId());
            }

            var myList = db.Tenants.Where(db => db.ID.Equals(userID));

            return View();
        }
        // GET: Accounting//PaymentDetails
        [AuthLog(Roles = "Tenant")]
        public ActionResult PaymentDetails()
        {
            ViewBag.Message = "Payment Details page.";

            var model = new SomeViewModel();
            model.Assets = db.Assets.ToList();
            model.FullAddresses = db.FullAddresses.ToList();
            model.Occupancies = db.Occupancies.ToList();

            return View(model);           
        }
        // GET: Accounting/OrderDetails()
        public ActionResult OrderDetails()
        {
            ViewBag.Message = "Order Details page.";

            return View();
        }
    }
}
