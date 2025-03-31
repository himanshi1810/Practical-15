using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class AccountController : Controller
    {
        private UserDbContext db = new UserDbContext();
        [Authorize]
        // GET: Account
        public ActionResult Profile()
        {
            string username = User.Identity.Name;
            User user = db.Users.FirstOrDefault(u => u.Username.Equals(username));
            if (user == null)
            {
                return HttpNotFound("User Not In the Database");
            }
            return View(user);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult AdminDashboard()
        {
            return View();
        }
    }
}