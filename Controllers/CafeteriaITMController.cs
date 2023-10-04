using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
//Agregar referencias de clases y modelos
using Servicios_Palomino.Clases;
using Servicios_Palomino.Models;


namespace Servicios_Palomino.Controllers
{   //localhost puerto de la aplicación
    [EnableCors(origins: "http://localhost:59187", headers: "*", methods: "*")]
    public class CafeteriaITMController : ApiController
    {
        // POST api/<controller>
        public CafereriaITM Post([FromBody] CafereriaITM cafereriaITM)
        {
            //Creo una instancia de la clase clsCafeteriaITM y paso los datos de entrada
            clsCafeteriaITM _cafeteriaITM = new clsCafeteriaITM();
            _cafeteriaITM.cafereriaITM = cafereriaITM;
            //Calcula los valores
            _cafeteriaITM.CalcularValorOriginal();
            //Retorna el objeto de cafeeria ITM con las respuestas
            return _cafeteriaITM.cafereriaITM;
        }
    }
}