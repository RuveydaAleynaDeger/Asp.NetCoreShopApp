using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopApp.business.Abstract;
using shopApp.data.Abstract;

using shopApp.entity;
using shopApp.webui.Models;

namespace shopApp.webui.Controllers
{
    public class HomeController : Controller
    {
        private IProductService  _productService;

        public HomeController(IProductService productService )
        {
            this._productService=productService;
        }
        public IActionResult Index(){

        var productListViewModel = new ProductListViewModel()
        {
       
            Products = _productService.GetHomePageProducts()
        };
            return View(productListViewModel);
        }
        
        public IActionResult About(){

            return View();
        }
         public IActionResult Contact(){

            return View();
        }
        
    }
}