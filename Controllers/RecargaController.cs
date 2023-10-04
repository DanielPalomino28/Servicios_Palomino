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
    public class RecargaController : ApiController
    {
        //Consultar
        public Recarga Get(string Documento)
        {
            clsRecarga _recarga = new clsRecarga();
            return _recarga.Consultar(Documento);
        }

        // Insertar
        public string Post([FromBody] Recarga recarga)
        {
            clsRecarga _recarga = new clsRecarga();
            _recarga.recarga = recarga;
            return _recarga.Insertar();
        }

        // Actualizar
        public string Put([FromBody] Recarga recarga)
        {
            clsRecarga _recarga = new clsRecarga();
            _recarga.recarga = recarga;
            return _recarga.Actualizar();
        }

        // Eliminar
        public string Delete([FromBody] Recarga recarga)
        {
            clsRecarga _recarga = new clsRecarga();
            _recarga.recarga = recarga;
            return _recarga.Eliminar();
        }
    }
}