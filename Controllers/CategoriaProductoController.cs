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
    public class CategoriaProductoController : ApiController
    {
        public CategoriasProducto Get(int Codigo)
        {
            clsCategoriaProducto _categoriaProducto = new clsCategoriaProducto();
            return _categoriaProducto.Consultar(Codigo);
        }
        public string Post([FromBody] CategoriasProducto _categoriaProducto)
        {
            clsCategoriaProducto categoriaProducto = new clsCategoriaProducto();
            categoriaProducto.categoriaProducto = _categoriaProducto;
            return categoriaProducto.Insertar();
        }
        public string Put([FromBody] CategoriasProducto _categoriaProducto)
        {
            clsCategoriaProducto categoriaProducto = new clsCategoriaProducto();
            categoriaProducto.categoriaProducto = _categoriaProducto;
            return categoriaProducto.Actualizar();
        }
        public string Delete(CategoriasProducto _categoriaProducto)
        {
            clsCategoriaProducto categoriaProducto = new clsCategoriaProducto();
            categoriaProducto.categoriaProducto = _categoriaProducto;
            return categoriaProducto.Eliminar();
        }
    }
}