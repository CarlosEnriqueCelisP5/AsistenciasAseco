using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AdministratorController : ControllerBase
    {
        [HttpGet("Prueba")]
        public IActionResult Prueba()
        {
            return Ok("Hola Mundo");
        }

         [HttpGet("AsistenciaM")]
        public IActionResult AsistenciaM()
        {
            return Ok("Mayra");
        }
    }

}