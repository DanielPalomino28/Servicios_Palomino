using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsCliente
    {
        public CLIEnte cliente { get; set; }
        private DBSuperEntitiesPalomino dbSuper = new DBSuperEntitiesPalomino();
        /*
        private void CalcularBono()
        {
            if (empleado.experiencia < 5)
            {
                empleado.bono = 0;
            }
            else
            {
                empleado.bono = 10;
            }
        }
        */
        public CLIEnte Consultar(string documento)
        {
            return dbSuper.CLIEntes.FirstOrDefault(e => e.Documento == documento);
        }
        public string Insertar()
        {
            //CalcularBono();
            try
            {
                dbSuper.CLIEntes.Add(cliente);
                dbSuper.SaveChanges();
                return "Se grabó el cliente con el documento: " + cliente.Documento;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar()
        {
            //CalcularBono();
            try
            {
                //dbSuper.EMPLeadoes.AddOrInsert(empleado);
                CLIEnte _cliente = Consultar(cliente.Documento);
                if (_cliente == null)
                {
                    return "El cliente con documento: " + cliente.Documento + ", no existe en la base de datos.";
                }
                _cliente.Nombre = cliente.Nombre;
                _cliente.PrimerApellido = cliente.PrimerApellido;
                _cliente.SegundoApellido = cliente.SegundoApellido;
                _cliente.Direccion = cliente.Direccion;
                _cliente.FechaNacimiento = cliente.FechaNacimiento;
                _cliente.Email = cliente.Email;
                dbSuper.SaveChanges();
                return "Se actualizó el cliente con el documento: " + cliente.Documento;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                CLIEnte _cliente = Consultar(cliente.Documento);
                if (_cliente == null)
                {
                    return "El cliente con documento: " + cliente.Documento + ", no existe en la base de datos";
                }
                dbSuper.CLIEntes.Remove(_cliente);
                dbSuper.SaveChanges();
                return "Se eliminó el cliente con documento: " + cliente.Documento+ ", de la base de datos.";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}