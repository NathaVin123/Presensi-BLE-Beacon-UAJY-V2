using Presensi_BLE_Beacon_UAJY.API.BM;
using Presensi_BLE_Beacon_UAJY.API.Model;
using Microsoft.AspNetCore.Authorization;
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
    public class AuthController : ControllerBase
    {
        private AuthBM bm;

        public AuthController()
        {
            bm = new AuthBM();
        }

        [AllowAnonymous]
        [HttpPost("LoginSiatma")]
        public ActionResult LoginSiatma(UserLogin ul)
        {
            try
            {
                var data = bm.LoginSiatma(ul.username, ul.password);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}