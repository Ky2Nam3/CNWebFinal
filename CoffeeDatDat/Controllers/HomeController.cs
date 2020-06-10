using CoffeeDatDat.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeDatDat.Controllers
{
    public class HomeController : Controller
    {
        private Data_Coffee db = new Data_Coffee();
        public ActionResult TrangChu()
        {  
            return View();
        }

        public ActionResult HienThiThem()
        {
            return View();
        }

        public ActionResult DatBan()
        {
            return View();
        }
        public ActionResult MENU()
        {
            var mode = db.Mons.Where(x => x.TenMon != null).ToList();
            return View(mode);
        }

        public ActionResult TuyenDung()
        {
            return View();
        }

        public ActionResult UngTuyen()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoadKhachHang()
        {
            var mode = db.KhachHangs.SqlQuery("LoadKhachHang");
            return View(mode);
        }

        public ActionResult LoadChiTietKhachHang(string id)
        {
            SqlParameter[] idParam ={  new SqlParameter {ParameterName = "MaKH", Value = id },

                                        };
            var model = db.KhachHangs.SqlQuery("LoadChiTietKH @MaKH", idParam).ToList();
            return View(model[0]);
        }



    }
}