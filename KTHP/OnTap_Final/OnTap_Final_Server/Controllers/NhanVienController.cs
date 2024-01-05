using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnTap_Final_Server.Models;

namespace OnTap_Final_Server.Controllers
{
    public class NhanVienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();
        [HttpGet]
        public List<NhanVien> layNV()
        {
            return db.NhanViens.ToList();
        }
        [HttpPost]
        public bool Them(int ma, string ten, string trinhdo, int luong)
        {
            NhanVien n = db.NhanViens.FirstOrDefault(nv => nv.MaNV == ma);
            if (n == null) {
                NhanVien nv = new NhanVien();
                nv.MaNV = ma;
                nv.HoTen = ten;
                nv.TrinhDo = trinhdo;
                nv.Luong = luong;
                db.NhanViens.Add(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        [HttpDelete]
        public bool Xoa(int ma) { 
            NhanVien nv = db.NhanViens.FirstOrDefault(n => n.MaNV == ma);
            if (nv != null) {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
