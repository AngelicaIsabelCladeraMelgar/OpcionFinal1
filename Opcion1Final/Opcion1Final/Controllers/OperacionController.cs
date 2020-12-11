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
            string palabra = "";
            if (numero < 0)
            {
                palabra = "ERROR";
            }
            else
            {
                if(numero==0)
                {
                    palabra = "Realizado por Isabel Cladera";
                }
                else
                {
                    palabra = "Usted ingreso el numero  " + numero;
                }
            }
            return palabra;
        }
        [HttpPost]
        public string Operacion2([FromHeader] int numero)
        {
            string palabra = "";
            if (numero < 0)
            {
                palabra = "ERROR";
            }
            else
            {
                if (numero == 0)
                {
                    palabra = "Realizado por Isabel Cladera";
                }
                else
                {
                    palabra = "Usted ingreso el numero" + numero;
                }
            }
            return palabra;
        }
    }
}
