using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//Agregar referencias de clases y modelos
using Servicios_Palomino.Clases;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Controllers
{
    public class ReservaController : ApiController
    {
        // POST api/<controller>
        public ReservasInder Post([FromBody] ReservasInder reservasInder)
        {
            //Creo una instancia de la clase clsReservasInder y paso los datos de entrada
            clsReservasInder _reservasInder = new clsReservasInder();
            _reservasInder.reservasInder = reservasInder;
            //Calcula los valores
            _reservasInder.CalcularValorSinDescuento();
            //Retorna el objeto de reservas Inder con las respuestas
            return _reservasInder.reservasInder;
        }
    }
}