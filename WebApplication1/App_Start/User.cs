using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Start
{
    [Table("User")]
    public class User
    {
        [Key]
        public string Username{ get; set; }
        public string Password { get; set; }

        public static bool IsLoggedIn()
        {
            bool isLoggedIn = false;
            if (HttpContext.Current.Session.Count > 0)
            {
                if (HttpContext.Current.Session["User"] != null)
                {
                    isLoggedIn = true;
                }
            }
            return isLoggedIn;
        }
    }
}