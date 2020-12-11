using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Opcion1Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionController : ControllerBase
    {
        [HttpGet]
        public string Operacion(int numero)
        { 
            if (numero < 0)
            {
                return "ERROR";
            }
            else
            {
                if(numero==0)
                {
                    return "Realizado por Isabel Cladera";
                }
                else
                {
                    return ("Usted ingreso el numero [0]");
                }
            }
        }
        [HttpPost]
        public string Operacion2([FromHeader] int numero)
        {
            if (numero < 0)
            {
                return "ERROR";
            }
            else
            {
                if (numero == 0)
                {
                    return "Realizado por Isabel Cladera";
                }
                else
                {
                    return "Usted ingreso el  {0}";
                }
            }
        }
    }
}
