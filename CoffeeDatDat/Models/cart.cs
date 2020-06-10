using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeDatDat.Models
{
    public class cart
    {
        public int MaMon { get; set; }

        public string TenMon { get; set; }

        public string HinhAnh { get; set; }

        public double DonGia { get; set; }

        public int SoLuong { get; set; }

        public double ThanhTien { get; set; }
        public cart(int iMaMon)
        {
            using (Data_Coffee db = new Data_Coffee())
            {
                this.MaMon = iMaMon;
                Mon Mon = db.Mons.Single(n => n.MaMon == iMaMon);
                this.TenMon = Mon.TenMon;
                this.HinhAnh = Mon.HinhAnh;
                this.DonGia = Mon.DonGia.Value;
                this.ThanhTien = DonGia * SoLuong;
            }
        }

        public cart(int iMaMon, int sl)
        {
            using (Data_Coffee db = new Data_Coffee())
            {
                this.MaMon = iMaMon;
                Mon Mon = db.Mons.Single(n => n.MaMon == iMaMon);
                this.TenMon = Mon.TenMon;
                this.HinhAnh = Mon.HinhAnh;
                this.DonGia = Mon.DonGia.Value;
                this.SoLuong = sl;
                this.ThanhTien = DonGia * SoLuong;
            }
        }
    }
}