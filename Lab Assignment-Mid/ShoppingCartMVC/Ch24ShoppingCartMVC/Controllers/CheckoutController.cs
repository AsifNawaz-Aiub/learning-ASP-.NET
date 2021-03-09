﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers
{
    public class CheckoutController : Controller
    {
        private CartModel cart = new CartModel();
        // GET: /Checkout/
        [HttpGet]
        public ActionResult Index()
        {
            CartViewModel model = (CartViewModel)TempData["cart"];
           //if (model == null)
                model = cart.GetCart();
                return View(model);
                //return View(model);
        }

    }
}
