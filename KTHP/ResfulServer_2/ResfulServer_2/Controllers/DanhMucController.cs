using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ResfulServer_2.Models;

namespace ResfulServer_2.Controllers
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
