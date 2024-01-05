using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.DynamicData;
using System.Web.Http;
using ResfulServer_2.Models;

namespace ResfulServer_2.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public List<SanPham> laySP()
        {
            return db.SanPhams.ToList();
        }
        [HttpGet]
        public List<SanPham> laySPTheoDM(int madm)
        {
            return db.SanPhams.Where(p => p.MaDanhMuc == madm).ToList();
        }
        [HttpGet]
        public SanPham laySP(int ma)
        {
            return db.SanPhams.FirstOrDefault(p => p.Ma == ma);
        }
        [HttpPost]
        public bool Them(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp == null)
            {
                sp = new SanPham();
                sp.Ma = ma;
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SanPhams.Add(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut]
        public bool Sua(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp != null)
            {
                sp.Ten = ten;
                sp.DonGia = gia;
                sp.MaDanhMuc = madm;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool Xoa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
