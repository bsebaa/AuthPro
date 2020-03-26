using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthPro.Models;
using AuthPro.Models.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthPro.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private readonly IProductRepository<Product> product;

        public HomeController(IProductRepository<Product> product)
        {
            this.product = product;
        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(product.List());
        }
        [AllowAnonymous]
        public ActionResult Details(int id)
        {

            return View(product.FindById(id));
        }

        [HttpGet]
      
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
   
        public ActionResult Create(Product product)
        {
            this.product.Add(product);
            ViewBag.Success = "1 product was added";
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            return View(product.FindById(id));
        }
        [HttpPost]
        public ActionResult Edit(Product pro)
        {
            this.product.Update(pro);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(product.FindById(id));
        }
    }
}