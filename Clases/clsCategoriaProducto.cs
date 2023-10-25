using Servicios_Palomino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Clases
{
    public class clsCategoriaProducto
    {
        public CategoriasProducto categoriaProducto { get; set; }
        private VentaAccesoriosEntities dbAccesorios = new VentaAccesoriosEntities();
        //public List<CategoriasProducto> ListarCategoriasProducto()
        //{
        //    return dbAccesorios.CategoriasProductos
        //        .Where(c => c.Activo == true)
        //        .OrderBy(c => c.Nombre)
        //        .ToList();
        //}
        //Método consultar
        public CategoriasProducto Consultar(int Codigo)
        {
            return dbAccesorios.CategoriasProductos.FirstOrDefault(c => c.Codigo == Codigo);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                dbAccesorios.CategoriasProductos.Add(categoriaProducto);
                dbAccesorios.SaveChanges();
                return "Se insertó la categoría de producto: " + categoriaProducto.Nombre + ", en la base de datos.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Método actualizar
        public string Actualizar()
        {
            try
            {
                //Se crea un objeto de Categoria Producto y se consulta
                CategoriasProducto _categoriaProducto = Consultar(categoriaProducto.Codigo);
                if (_categoriaProducto == null)
                {
                    return "No se encontró la categoría producto.";
                }
                //TIpoPRoducto _tipoproducto = Consultar(tipoProducto.Codigo);
                //Asignar los valores a _tipoProducto del objeto que se pasó a la clase: tipoProducto
                _categoriaProducto.Nombre = categoriaProducto.Nombre;
                _categoriaProducto.Activo = categoriaProducto.Activo;
                //Guarda los datos en la base de datos
                dbAccesorios.SaveChanges();
                return "Se actualizó la información de la categoría producto: " + categoriaProducto.Nombre;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        //Método eliminar
        public string Eliminar()
        {
            try
            {
                //Se consulta el objeto
                CategoriasProducto _categoriaProducto = dbAccesorios.CategoriasProductos.FirstOrDefault(c => c.Codigo == categoriaProducto.Codigo);
                if (_categoriaProducto == null)
                {
                    return "No se encontró el tipo de producto";
                }
                //Se elimina (Remueve) de la base de datos
                dbAccesorios.CategoriasProductos.Remove(_categoriaProducto);
                dbAccesorios.SaveChanges();
                return "Se eliminó la categoría de producto: " + _categoriaProducto.Nombre;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}