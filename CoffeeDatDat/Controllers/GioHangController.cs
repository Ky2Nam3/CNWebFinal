using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using CoffeeDatDat.Models;

namespace CoffeeDatDat.Controllers
{
    public class GioHangController : Controller
    {
        Data_Coffee db = new Data_Coffee();
        // GET: GioHang
        public ActionResult XemGioHang()
        {
            return View();
        }

        public ActionResult GioHangPartial()
        {
            if(TinhTongSL() == 0)
            {
                ViewBag.Tongsoluong = 0;
                ViewBag.TongTien = 0;
                return PartialView();
            }
            ViewBag.Tongsoluong = TinhTongSL();
            ViewBag.TongTien = TinhTongTien();
            return PartialView();
        }

        // Lấy Giỏ Hàng
        public List<cart> Laygiohang()
        {
            // giỏ hàng đã tồn tại
            List<cart> lstGioHang = Session["cart"] as List<cart>;
            if(lstGioHang == null)
            {
                List<cart> lstGH = new List<cart>();
                Session["cart"] = lstGioHang;
            }
            return lstGioHang;
        }

        // Thêm giỏ hàng
        public ActionResult ThemGioHang(int MaMon, string strURL)
        {
            // kiểm tra sản phẩm có tồn tại trong csdl hay k
            Mon mon = db.Mons.SingleOrDefault(n => n.MaMon == MaMon);
            if(mon == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            // lấy giỏ hàng
            List<cart> lstGioHang = Laygiohang();
            // TH1 sản phẩm đã tồn tại trong giỏ hàng
            cart moncheck = lstGioHang.SingleOrDefault(n => n.MaMon == MaMon);
            if (moncheck != null)
            {
                moncheck.SoLuong++;
                return Redirect(strURL);
            }
            cart itemGH = new cart(MaMon);
            lstGioHang.Add(itemGH);
            return Redirect(strURL);
        }
        public double TinhTongSL()
        {
            // lấy giỏ hàng
            List<cart> lstGioHang = Session["cart"] as List<cart>;
            if(lstGioHang == null)
            {
                return 0;
            }
            return lstGioHang.Sum(n => n.SoLuong);
        }
        // tính tổng tiền
        public double TinhTongTien()
        {
            // lấy giỏ hàng
            List<cart> lstGioHang = Session["cart"] as List<cart>;
            if (lstGioHang == null)
            {
                return 0;
            }
            return lstGioHang.Sum(n => n.ThanhTien);
        }

    }
}