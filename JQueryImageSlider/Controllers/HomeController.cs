using JQueryImageSlider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQueryImageSlider.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ImageModel> imageList = new List<ImageModel>();

            imageList.Add(new ImageModel { ImageID = 1, ImageName = "Image 1", ImagePath = "/img/the-battle.jpg" });
            imageList.Add(new ImageModel { ImageID = 2, ImageName = "Image 2", ImagePath = "/img/hiding-the-map.jpg" });
            imageList.Add(new ImageModel { ImageID = 3, ImageName = "Image 3", ImagePath = "/img/theres-the-buoy.jpg" });
            imageList.Add(new ImageModel { ImageID = 4, ImageName = "Image 4", ImagePath = "/img/finding-the-key.jpg" });
            imageList.Add(new ImageModel { ImageID = 5, ImageName = "Image 5", ImagePath = "/img/lets-get-out-of-here.jpg" });

            return View(imageList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}