using Servicios_Palomino.Clases;
using Servicios_Palomino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Servicios_Palomino.Controllers
{
    [EnableCors(origins: "http://localhost:59187", headers: "*", methods: "*")]
    public class ProveedorController : ApiController
    {
        public Proveedore Get(int Codigo)
        {
            clsProveedor _proveedor = new clsProveedor();
            return _proveedor.Consultar(Codigo);
        }
        public string Post([FromBody] Proveedore _proveedor)
        {
            clsProveedor proveedor = new clsProveedor();
            proveedor.proveedoR = _proveedor;
            return proveedor.Insertar();
        }
        public string Put([FromBody] Proveedore _proveedor)
        {
            clsProveedor proveedor = new clsProveedor();
            proveedor.proveedoR = _proveedor;
            return proveedor.Actualizar();
        }
        public string Delete(Proveedore _proveedor)
        {
            clsProveedor proveedor = new clsProveedor();
            proveedor.proveedoR = _proveedor;
            return proveedor.Eliminar();
        }
    }
}