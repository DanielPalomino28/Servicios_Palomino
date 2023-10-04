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
    public class ClienteController: ApiController
    {
        // Consultar
        public CLIEnte Get(string Documento)
        {
            clsCliente _cliente = new clsCliente();
            return _cliente.Consultar(Documento);
        }

        // Insertar
        public string Post([FromBody] CLIEnte cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Insertar();
        }

        // Actualizar
        public string Put([FromBody] CLIEnte cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Actualizar();
        }

        // Eliminar
        public string Delete([FromBody] CLIEnte cliente)
        {
            clsCliente _cliente = new clsCliente();
            _cliente.cliente = cliente;
            return _cliente.Eliminar();
        }
    }
}