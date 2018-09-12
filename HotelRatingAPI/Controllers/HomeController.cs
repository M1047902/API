using HotelRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelRatingAPI.Controllers
{
    public class HomeController : Controller
    {
        HotelRatingEntities modelobj = new HotelRatingEntities();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
         
        public ActionResult GetAllHotels()
        {
            return View(modelobj.Hotels.ToList());

        }

        public ActionResult GetMenuItems()
        {
            return View(modelobj.MenuItems.ToList());

        }
        [HttpPost]
        public ActionResult InsertToHotelRating(HotelRating hotelRating)
        {
            modelobj.HotelRatings.Add(hotelRating);            
            return View(modelobj.SaveChanges());
        }
        public ActionResult GetBestOftheHotel()
        {
            return View(modelobj.BestOftheHotels.ToList());

        }
        public ActionResult InsertBestOftheHotel(BestOftheHotel bestOfTheHotel)
        {
            modelobj.BestOftheHotels.Add(bestOfTheHotel);
            return View(modelobj.SaveChanges());

        }
    }
}
