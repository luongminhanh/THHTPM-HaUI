using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_Server.Models;

namespace WebAPI_Server.Controllers
{
    public class SanPhamController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public IEnumerable<SanPham> LaySP()
        {
            IEnumerable<SanPham> query = db.SanPhams;
            return query;
        }
        [HttpGet]
        public SanPham LaySPTheoMa(int ma)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            return sp;
        }
        [HttpPost]
        public bool ThemMoi(int ma, string ten, int gia, int madm)
        {
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
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
            SanPham sp1 = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
            if (sp1 != null)
            {
                sp1.Ma = ma;
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
            SanPham sp = db.SanPhams.FirstOrDefault(x => x.Ma == ma);
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
