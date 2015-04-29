using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_MVC.Models;

namespace WebApplication_MVC.Controllers
{
    public class ConferenceController : Controller
    {
        // GET: Conference
        public ActionResult Index()
        {
            return View();
        }

        // GET: Conference
        public ActionResult RSVP()
        {
            return View();
        }

        // Post: Conference
        [HttpPost]
        public string RSVP(RSVP rs)
        {
            return rs.Name + " "+rs.Email;
        }
    }
}