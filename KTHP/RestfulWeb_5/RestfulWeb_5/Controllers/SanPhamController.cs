using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulWeb_5.Models;

namespace RestfulWeb_5.Controllers
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
        public List<SanPham> laySPTheoMa(int madm)
        {
            return db.SanPhams.Where(sp => sp.MaDanhMuc == madm).ToList();
        }
        [HttpPost]
        public bool Them(int ma, string ten, int gia, int madm)
        {
            SanPham sp1 = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp1 == null)
            {
                SanPham sp = new SanPham();
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
