using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsRecarga
    {
        public Recarga recarga { get; set; }
        private DBExamenEntities dbRecarga = new DBExamenEntities();
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
        public Recarga Consultar(string documento)
        {
            return dbRecarga.Recargas.FirstOrDefault(e => e.Documento == documento);
        }
        public string Insertar()
        {
            //CalcularBono();
            try
            {
                dbRecarga.Recargas.Add(recarga);
                dbRecarga.SaveChanges();
                return "Se grabó la recarga para el cliente con el documento: " + recarga.Documento;
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
                Recarga _recarga = Consultar(recarga.Documento);
                if (_recarga == null)
                {
                    return "La recarga para el documento: " + recarga.Documento + ", no existe en la base de datos";
                }
                _recarga.NombreCompleto = recarga.NombreCompleto;
                _recarga.ValorRecarga = recarga.ValorRecarga;
                _recarga.ValorIncremento = recarga.ValorIncremento;
                _recarga.TotalRecarga = recarga.TotalRecarga;
                dbRecarga.SaveChanges();
                return "Se actualizó la recarga para el documento: " + recarga.Documento;
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
                Recarga _recarga = Consultar(recarga.Documento);
                if (_recarga == null)
                {
                    return "La recarga para el documento: " + recarga.Documento + ", no existe en la base de datos";
                }
                dbRecarga.Recargas.Remove(_recarga);
                dbRecarga.SaveChanges();
                return "Se eliminó la recarga en la base de datos, documento: " + recarga.Documento;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}