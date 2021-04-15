using Presensi_BLE_Beacon_UAJY.API.BM;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presensi_BLE_Beacon_UAJY.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DsnController : ControllerBase
    {
        private DsnBM bm;

        public DsnController()
        {
            bm = new DsnBM();
        }

        public ActionResult Get()
        {
            try
            {
                var npp = User.Claims
                        .Where(c => c.Type == "username")
                            .Select(c => c.Value).SingleOrDefault();

                var data = bm.GetDsnProfil(npp);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}