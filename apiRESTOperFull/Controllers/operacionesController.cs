using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiRESTOperFull.Models;

namespace apiRESTOperFull.Controllers
{
    public class operacionesController : ApiController
    {
        public static clsOperaciones[] objOperaciones = new clsOperaciones[5]
        {
            new clsOperaciones(), // [0] Cono truncado
            new clsOperaciones(), // [1] Esfera hueca
            new clsOperaciones(), // [2] Esfera maciza
            new clsOperaciones(), // [3] Cilindro hueco
            new clsOperaciones()  // [4] Hemisferio hueco
        };


    }
}
