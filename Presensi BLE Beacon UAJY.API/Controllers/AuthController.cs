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
        [HttpPost("LoginMhs")]
        public ActionResult LoginMhs(UserLoginMhs ul)
        {
            try
            {
                var data = bm.LoginMhs(ul.NPM, ul.PASSWORD);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}