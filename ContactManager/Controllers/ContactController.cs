using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        // return the array of strings
        public Contact[] Get()
        {
            return new Contact[]
            {
                new Contact
                {
                    UserId = 1,
                    UserName = "Robert"
                },
                new Contact
                {
                    UserId = 2,
                    UserName = "Godfrey"
                }
            };
        }
    }
}