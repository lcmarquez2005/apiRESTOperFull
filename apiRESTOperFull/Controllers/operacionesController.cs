using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiRESTOperFull.Models;

namespace apiRESTOperFull.Controllers
{
    [RoutePrefix("oper/operaciones")]
    public class operacionesController : ApiController
    {
        public static clsOperaciones[] objOperaciones = new clsOperaciones[5];


        // Post oper/operaciones/calculos
        [HttpPost]
        [Route("calculos")]
        public IHttpActionResult Post([FromBody] clsOperaciones modelo)
        {
            double resultado = 0;
            string tipo = modelo.Calculo;

            switch (tipo)
            {
                case "cono":
                    resultado = (1.0 / 3.0 ) * Math.PI *
                                modelo.Oper3 *
                                (Math.Pow(modelo.Oper1, 2) +
                                 Math.Pow(modelo.Oper2, 2) +
                                 (modelo.Oper1 * modelo.Oper2));

                    objOperaciones[0] = modelo;
                    break;

                case "esfH":
                    resultado = (4.0 / 3.0) * Math.PI *
                        (Math.Pow(modelo.Oper1, 3) -
                         Math.Pow(modelo.Oper2, 3));

                    objOperaciones[1] = modelo;
                    break;

                case "esfM":
                    resultado = (4.0 / 3.0) * Math.PI *
                                Math.Pow(modelo.Oper1, 3);

                    objOperaciones[2] = modelo;
                    break;

                case "cilin":
                    resultado = Math.PI *
                                Math.Pow(modelo.Oper1, 2) *
                                modelo.Oper2;

                    objOperaciones[3] = modelo;
                    break;

                case "hemis":
                    resultado = (2.0 / 3.0) * Math.PI *
                                (Math.Pow(modelo.Oper1, 3) -
                                 Math.Pow(modelo.Oper2, 3));

                    objOperaciones[4] = modelo;
                    break;

                default:
                    return BadRequest("Tipo de cálculo no válido");
            }
            modelo.Resultado = resultado;

            return Ok(modelo);
        }


        // GET oepr/operaciones/consultagral
        [HttpGet]
        [Route("consultagral")]
        public IHttpActionResult GetConsultaGeneral()
        {
            return Ok(objOperaciones);
        }


        // GET oper/ operacoines/consultagral/{id}
        [HttpGet]
        [Route("consultaesp/{id}")]
        public IHttpActionResult GetConsultaEspecifica(int id)
        {
            // Validar rango permitido
            if (id < 0 || id > 4)
            {
                return BadRequest("El id debe estar en el rango de 0 a 4.");
            }

            return Ok(objOperaciones[id]);
        }





    }
}
