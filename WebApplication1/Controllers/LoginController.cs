using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.App_Start;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult LoggaIn(LoginViewModel model)
        {
           
            User user = new User();

            using (var db = new SQLContext())
            {
                user = db.User.FirstOrDefault(u => u.Username == model.Username && u.Password == model.Password);
            }
            if ((user != null))
            {
                Session["User"] = user.Username;

                return View();
            }
                
            else
                return RedirectToAction("LoggaIn", "Home");
        }

        public ActionResult Loggaut()
        {
            Session.Clear();

            return View("LoggaUt");
        }
        //public ActionResult CheckUser(LoginViewModel model)
        //{
        //    User user = new User();
        //    using (var db = new SQLContext())
        //    {
        //        user = db.User.FirstOrDefault(x => x.Username == model.Username);
        //    }
        //    return 
        //}
	}
}