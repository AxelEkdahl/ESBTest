using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Start
{
    [Table("User")]
    public class User
    {
        public string Username{ get; set; }
        public string Password { get; set; }
    }
}