using HotelRatingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace HotelRatingAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        HotelRatingEntities modelobj = new HotelRatingEntities();
        public ValuesController()
        {
            modelobj.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        public HttpResponseMessage GetAllHotels()
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.Hotels.ToList());

        }

        [HttpPost]
        public HttpResponseMessage InsertToHotelRating(HotelRating hotelRating)
        {
            modelobj.HotelRatings.Add(hotelRating);
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.SaveChanges());
        }
        [HttpPost]
        public HttpResponseMessage ValidateLogin(Customer customer)
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.Customers.Where(m => m.CustomerName == customer.CustomerName && m.password == customer.password).FirstOrDefault());


        }
        [HttpPost]
        public HttpResponseMessage GetHotelRatings(Hotel hotel)
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.HotelRatings.Where(m => m.HotelID == hotel.HotelID).OrderByDescending(m => m.CreatedDate).ToList());
        }

        [HttpGet]
        public HttpResponseMessage GetAllCustomers()
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.Customers.ToList());
        }
        [HttpGet]

        public HttpResponseMessage GetMenuItems()
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.MenuItems.ToList());
        }
        [HttpGet]
        public HttpResponseMessage GetBestoftheHotel()
        {
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.BestOftheHotels.ToList());
        }
        [HttpPost]
        public HttpResponseMessage InsertCustomer(Customer customer)
        {
            modelobj.Customers.Add(customer);
            return Request.CreateResponse(HttpStatusCode.OK, modelobj.SaveChanges());

        }
        [HttpPost]
        public HttpResponseMessage InsertBestOftheHotel(BestOftheHotel bestOfTheHotel)
        {
            BestOftheHotel tobeInserted = new BestOftheHotel();
            tobeInserted = modelobj.BestOftheHotels.Where(m => m.HotelID == bestOfTheHotel.HotelID && m.MenuItemID == bestOfTheHotel.MenuItemID).FirstOrDefault();
            if (tobeInserted != null)
            {
                int noofSuggestions = tobeInserted.NoofSuggenstions;
                tobeInserted.NoofSuggenstions = noofSuggestions + 1;

                return Request.CreateResponse(HttpStatusCode.OK, modelobj.SaveChanges());
            }
            else
            {
                modelobj.BestOftheHotels.Add(bestOfTheHotel);
                return Request.CreateResponse(HttpStatusCode.OK, modelobj.SaveChanges());
            }

        }
    }
}
