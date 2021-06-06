using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;
using TechnicalStore.DataBaseConnection;
using TechnicalStore.DataBaseConnection.db.connections;
using TechnicalStore.DataBaseConnection.Factory;
using TechnicalStore.Models;

namespace TechnicalStore.Controllers
{

    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
        }
        
 

        public IActionResult All_Tovars()
        {
            var AllProduct = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());
            ViewBag.allproduct = AllProduct;
            return View();
        }
        [HttpGet]
        public IActionResult Buy(int id)
        {
            var AllProduct = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());
            
            ViewBag.TovarId = id;
            foreach(Product tov in AllProduct)
            {
                if (tov.Id == id)
                {
                    ViewBag.Obj = tov;
                    break;
                }
            }    
            return View();
        }
        [HttpPost]
        public IActionResult Buy(User user, int tid)
        {
            var lstbasket = Factory.GetAllBasket(DatabaseConnection.GetBasket());
            foreach(Basket x in lstbasket)
            {
                if(user.Id == x.Profile_Id && x.Product_Id == tid)
                    return Redirect("/Home/All_Tovars");

            }
                Factory.AddToBasket(user.Id, tid);
            return Redirect("/Home/All_Tovars");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Order(int orderTovarId)
        
        {
            ViewBag.OrderTovarId = orderTovarId;
            string t="";
            foreach (var x in User.Claims)
            {
                if (x.Value != null)
                {
                    t = x.Value;
                    break;
                }
                    
                
            }
            var users = Factory.GetAllProfileInformation(DatabaseConnection.GetAllProfileInformation());
            foreach (User user in users)
            {
                if (user.Id == Convert.ToInt32(t))
                {
                    ViewBag.User = user;
                    break;
                }
            }
            int prs = 0;
           var lstUser = Factory.GetBasket(DatabaseConnection.GetBasket(Convert.ToInt32(t)));
            var AllProduct = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());
            List<Product> ls = new List<Product>();
            foreach (Basket x in lstUser)
            {
                foreach (Product prod in AllProduct)
                {
                    if (x.Product_Id == prod.Id)
                    {
                        ls.Add(prod);
                        prs += prod.Price;
                        break;
                       
                    }
                }
            }
            ViewBag.Try = ls.Count;
            ViewBag.FullPrice = prs;
            ViewBag.BasketUser = ls;
            return View();
        }
        [HttpPost]
        public IActionResult Order(int user, int tid)
        {
            Factory.RemoveFromBasket(user, tid);
            return Redirect("/Home/Order");
        }
        [HttpPost]
        public IActionResult AcceptOrder()
        {
            
            string t = "";
            foreach (var x in User.Claims)
            {
                if (x.Value != null)
                {
                    t = x.Value;
                    break;
                }


            }
            int prs = 0;
          
            
            var lstUser = Factory.GetBasket(DatabaseConnection.GetBasket(Convert.ToInt32(t)));
            var AllProduct = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());

          

            List<Product> ls = new List<Product>();
            foreach (Basket x in lstUser)
            {
                foreach (Product prod in AllProduct)
                {
                    if (x.Product_Id == prod.Id)
                    {
                        ls.Add(prod);
                        prs += prod.Price;
                        Factory.BuyProduct(prod);
                        Factory.RemoveFromBasket( x.Product_Id);
                       
                        break;

                    }
                    
                }
            }
            
            ViewBag.FullPrice = prs;
            var prof = Factory.GetProfileInformation(DatabaseConnection.GetProfileInformation(Convert.ToInt32(t)));
            Factory.PutMoney(prof, prs);
            var balance = Factory.GetProfileBalanace(DatabaseConnection.GetProfileBalanace(Convert.ToInt32(t)));
            ViewBag.Balance = balance;
            ViewBag.BasketUser = ls;
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }
        public IActionResult Index()
        {
           
            List<Product> alltov = Factory.GetAllProduct(DatabaseConnection.GetAllProduct());
            alltov.Reverse();
            ViewBag.AllTovars = alltov;
          
            ViewBag.It = 0;

            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Message mes)

        {
            return View();
        }
       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
