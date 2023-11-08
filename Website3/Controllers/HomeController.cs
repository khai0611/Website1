using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website3.Helper;
using Website3.Models;

namespace Website3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Method 1: Transmit by Viewbag
            MathHelp mh = new MathHelp();
            ViewBag.A = mh.Sum(10, 15);

            //Method 2: Transmit Transmit through parameters of View function
            //return View(10);

            //1.Declare Array of list
            List<clsSinhVien> dsSinhVien = new List<clsSinhVien>();

            //2.Declare Objects
            var sv1 = new clsSinhVien();
            sv1.ID = 1;
            sv1.Code = "SV01";
            sv1.Name = "QK";
            sv1.Class = "TH01";

            //3.put the object in the list
            dsSinhVien.Add(sv1);

            var sv2 = new clsSinhVien();
            sv2.ID = 2;
            sv2.Code = "SV02";
            sv2.Name = "TK";
            sv2.Class = "TH02";
            
            dsSinhVien.Add(sv2);

            //4.transmit list into View
            return View(dsSinhVien);
        }

        
    }
}