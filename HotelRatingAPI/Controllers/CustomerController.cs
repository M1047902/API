using HotelRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelRatingAPI.Controllers
{
    public class CustomerController : Controller
    {
        HotelRatingEntities modelobj = new HotelRatingEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomer()
        {
            return View(modelobj.Customers.ToList());
            
        }

      



    }
}