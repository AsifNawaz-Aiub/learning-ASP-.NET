using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers {
    public class CartController : Controller
    {
        private CartModel cart = new CartModel();

        [HttpGet]
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("List/");
        }
        [HttpGet]
      /*  public ViewResult List()
        {
            CartViewModel model = (CartViewModel)TempData["cart"];
            //if the model is null, then call the method GetCart
          
            //Passing model to View
            //return ; ___________________
        }*/
        [HttpPost]
        public RedirectToRouteResult List(OrderViewModel order)
        {
            CartViewModel model = cart.GetCart(order.SelectedProduct.ProductID);
            //Assign the quantity of the selected product to the quantity of the added product
         
            //Call the method AddtoCart
           
            //Assign model to the TempData
            
            return RedirectToAction("List", "Cart");
        }
       
    }
}
