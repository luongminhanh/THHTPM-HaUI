using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulWeb_1.Models;

namespace RestfulWeb_1.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities db = new CSDLTestEntities();
        [HttpGet]
        public List<DanhMuc> layDM()
        {
            return db.DanhMucs.ToList();
        }
    }
}
