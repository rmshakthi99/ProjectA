using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PizzaMVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMVCProject.Controllers
{
    public class PizzaController : Controller
    {
        
        public async Task<ActionResult> Menu()
        {

            string Baseurl = "http://localhost:5000/";
            var PizzaInfo = new List<PizzaDetail>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                //Define Request Data Format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Sending request to find webapi REST service resource GetAllPizzaDetails using HttpClient
                HttpResponseMessage Res = await client.GetAsync("api/PizzaDetails");
                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details received from web api
                    var PizzaResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response received from web api and storing into the view
                    PizzaInfo = JsonConvert.DeserializeObject<List<PizzaDetail>>(PizzaResponse);
                    // TempData["Name"] = PizzaInfo[0].PizzaName;
                }
            }

            return View(PizzaInfo);
        }

        //[ HttpGet("{PizzaId}")]
        public ActionResult OrderPizza(int PizzaId, string PizzaName, int Amount)
        {
            // PizzaDetail p = new PizzaDetail();
            ViewBag.PizzaId = PizzaId;
            ViewBag.PizzaName = PizzaName;
            ViewBag.Amount = Amount;
            //TempData["Name"] = ViewBag.PizzaName;
            //p.PizzaName = PizzaName;
            //TempData["Name"] = p.PizzaName;
            return View();
        }

        // POST: PizzaDetailsController/OrderPizza
        [HttpPost]
        public async Task<ActionResult> OrderPizza(Customer b)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(b), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:5000/api/Customers/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                   // var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);

                }
            }
            //return RedirectToAction("Summary");
            return View(b);

        }
        [HttpGet]
        public ActionResult Summary()
        {            
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Summary(OrderSummary summary)
        {


            Customer customer = new Customer();
            customer.CustomerName = summary.CustomerName;
            customer.DeliveryAddress = summary.DeliveryAddress;
            customer.Email = summary.Email;
            customer.Crust = summary.Crust;
            customer.MobileNumber = summary.MobileNumber;
            customer.Toppings = summary.Toppings;
            customer.Quantity = summary.Quantity;

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:5000/api/Customers/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    summary.CustomerId = obj.CustomerId;

                }
            }
            
            return View(summary);
        }
        [HttpGet]
        public async Task<ActionResult> FinalOrder(Order info)
        {
            using (var httpClient = new HttpClient())
            {
                info.OrderDate = DateTime.Now;
                StringContent content = new StringContent(JsonConvert.SerializeObject(info), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:5000/api/Orders/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Order>(apiResponse);
                    ViewBag.OrderId = obj.OrderId;
                }
            }
            return View();
        }
        //[HttpPost]
        //public async Task<ActionResult> FinalOrder(Order m)
        //{
        //    Order o = new Order();
        //    o.PizzaId = m.PizzaId;
        //    o.CustomerId = m.CustomerId;
        //    o.OrderDate = m.OrderDate;
        //    o.TotalAmount = m.TotalAmount;

        //    using (var httpClient = new HttpClient())
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8, "application/json");

        //        using (var response = await httpClient.PostAsync("http://localhost:5000/api/Orders/", content))
        //        {
        //            string apiResponse = await response.Content.ReadAsStringAsync();
        //            var obj = JsonConvert.DeserializeObject<Order>(apiResponse);
        //            m.CustomerId = obj.CustomerId;

        //        }
        //    }
        //    return View(m);
       // }
    }
}
