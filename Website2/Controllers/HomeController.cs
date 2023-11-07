using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TrangChu()
        {
            //redirect to another action, have common controller
            //return RedirectToAction("DangNhap");

            //redirect to different controller
            //return RedirectToAction("DanhSachTinTuc", "TinTuc");

            //redirect to URL
            //return Redirect("https://google.com");

            return View();
        }

        public ActionResult GioiThieu()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
    }
}