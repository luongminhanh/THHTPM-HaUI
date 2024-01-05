using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulWeb_1.Models;

namespace RestfulWeb_1.Controllers
{
    //http://localhost:91/hocrestful/api/sanpham
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public List<SanPham> laySP()
        {
            return db.SanPhams.ToList();
        }
        [HttpGet]
        public List<SanPham> timTheoDM(int madm)
        {
            return db.SanPhams.Where(sp => sp.MaDanhMuc == madm).ToList();
        }
        [HttpGet]
        public SanPham timTheoMa(int ma)
        {
            return db.SanPhams.FirstOrDefault(sp=> sp.Ma == ma);
        }
        [HttpPost]
        public bool ThemMoi(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp == null)
            {
                SanPham sp1 = new SanPham();
                sp1.Ma = ma;
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
                db.SanPhams.Add(sp1);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpPut] 
        public bool CapNhat(int ma, string ten, int gia, int madm)
        {
            SanPham sp1 = db.SanPhams.FirstOrDefault(p => p.Ma == ma);
            if (sp1 != null)
            {
                sp1.Ten = ten;
                sp1.DonGia = gia;
                sp1.MaDanhMuc = madm;
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
