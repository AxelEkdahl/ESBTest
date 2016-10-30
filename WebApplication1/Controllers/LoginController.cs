using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.App_Start;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        public ActionResult LoggaIn(FormCollection collection)
        {
            var username = collection["Username"];
            var password = collection["Password"];
            using (var db = new SQLContext())
            {
                var user = db.User.FirstOrDefault(u => u.Username == username);
            }
            return View();
        }
	}
}