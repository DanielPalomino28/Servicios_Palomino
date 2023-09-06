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
    public class ServiciosEpmController : ApiController
    {
        // POST api/<controller>
        public ServiciosEpm Post([FromBody] ServiciosEpm serviciosEpm)
        {
            //Creo una instancia de la clase clsServiciosEpm y paso los datos de entrada
            clsServiciosEpm _serviciosEpm = new clsServiciosEpm();
            _serviciosEpm.serviciosEpm = serviciosEpm;
            //Calcula los valores
            _serviciosEpm.CalcularValoresTotales();
            //Retorna el objeto de reservas Inder con las respuestas
            return _serviciosEpm.serviciosEpm;
        }
    }
}