using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LuongMinhAnh_server.Models;

namespace LuongMinhAnh_server.Controllers
{
    public class NhanVienController : ApiController
    {
        QLNVEntities db = new QLNVEntities();
        [HttpGet]
        public List<NhanVien> DanhsachNV()
        {
            return db.NhanViens.ToList();
        }
        [HttpPost]
        public bool ThemNV(int ma, string ten, string trinhdo, int luong) 
        {
            NhanVien nv1 = db.NhanViens.FirstOrDefault(p => p.MaNV == ma);
            if (nv1 == null)
            {
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
        public bool XoaNV(int ma)
        {
            NhanVien nv = db.NhanViens.FirstOrDefault(p => p.MaNV == ma);
            if (nv != null)
            {
                db.NhanViens.Remove(nv);
                db.SaveChanges();
                return true;
            }
            return false;

        }
    }
}
