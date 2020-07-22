using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class ProductController : Controller
    {
        //localhost:5000/product/list
        public IActionResult Index()
        {//yazdımki product yazınca locale hemen product index çalışsın çünkü startupta action ındex
            return View();
        }
        public IActionResult list()
        {
            return View();
        }
        //localhost:5000/product/details/2
        public IActionResult Details(int id)
        {//ürünü temsil edecek olan 3 bilgi
            //name:"samsung s6"
            //price: 3000
            //description: "İyi telefon"

            // ViewBag.Name="Samsung s6";
            // ViewBag.Price=3000;
            // ViewBag.Description="İyi telefon";crtl k c

            var p = new Product();//nesne ürettik
            p.Name = "Samsung";
            p.Price = 3000;
            p.Description = "İyi telefon";

//ismi p tipi product
            return View(p);//pyi gönderdim viewe şimdi viewe product clasının yolunu ve clasını yazmam lazım
        }


    }
}