using Servicios_Palomino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Clases
{
    public class clsProveedor
    {
        public Proveedore proveedoR { get; set; }
        private VentaAccesoriosEntities dbAccesorios = new VentaAccesoriosEntities();
        //public List<CategoriasProducto> ListarCategoriasProducto()
        //{
        //    return dbAccesorios.CategoriasProductos
        //        .Where(c => c.Activo == true)
        //        .OrderBy(c => c.Nombre)
        //        .ToList();
        //}
        //Método consultar
        public Proveedore Consultar(int Codigo)
        {
            return dbAccesorios.Proveedores.FirstOrDefault(c => c.Codigo == Codigo);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                dbAccesorios.Proveedores.Add(proveedoR);
                dbAccesorios.SaveChanges();
                return "Se insertó el proveedor: " + proveedoR.Nombre + ", en la base de datos.";
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
                Proveedore _proveedor = Consultar(proveedoR.Codigo);
                if (_proveedor == null)
                {
                    return "No se encontró el proveedor.";
                }
                //TIpoPRoducto _tipoproducto = Consultar(tipoProducto.Codigo);
                //Asignar los valores a _tipoProducto del objeto que se pasó a la clase: tipoProducto
                _proveedor.Nombre = proveedoR.Nombre;
                _proveedor.Activo = proveedoR.Activo;
                //Guarda los datos en la base de datos
                dbAccesorios.SaveChanges();
                return "Se actualizó la información del proveedor: " + proveedoR.Nombre;
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
                Proveedore _proveedor = dbAccesorios.Proveedores.FirstOrDefault(c => c.Codigo == proveedoR.Codigo);
                if (_proveedor == null)
                {
                    return "No se encontró el proveedor";
                }
                //Se elimina (Remueve) de la base de datos
                dbAccesorios.Proveedores.Remove(_proveedor);
                dbAccesorios.SaveChanges();
                return "Se eliminó la información del proveedor: " + proveedoR.Codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}