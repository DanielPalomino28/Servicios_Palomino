using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Servicios_Palomino.Models;
using Servicios_Palomino.Clases;
using System.Web.Http.Cors;

namespace Servicios_Palomino.Controllers
{
    [EnableCors(origins: "http://localhost:59187", headers: "*", methods: "*")]
    public class EmpleadoController : ApiController
    {
        public EMPLeado Get(string Documento)
        {
            clsEmpleado _empleado = new clsEmpleado();
            return _empleado.Consultar(Documento);
        }

        // POST api/<controller>
        public string Post([FromBody] EMPLeado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] EMPLeado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] EMPLeado empleado)
        {
            clsEmpleado _empleado = new clsEmpleado();
            _empleado.empleado = empleado;
            return _empleado.Eliminar();
        }
    }
}