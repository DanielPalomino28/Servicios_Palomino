using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Models
{
    public class SeguroVehiculos
    {
        public SeguroVehiculos()
        {
            UnaReclamacion = 0.05;
            DosReclamaciones = 0.15;
            TresReclamaciones = 0.30;
            CuatroOMasReclamaciones = 0.5;
            PorcentajeIva = 0.16;
        }

        //Atributos
        public double UnaReclamacion { get; set; }
        public double DosReclamaciones { get; set; }
        public double TresReclamaciones { get; set; } 
        public double CuatroOMasReclamaciones { get; set; }
        public double PorcentajeIva { get; set; }

        //Datos de entrada
        public double ValorComercial { get; set; }
        public double ReclamacionesAnioAnterior { get; set; }

        //Datos de salida
        public double ValorBase { get; set; }
        public double ValorIncremento { get; set; }
        public double ValorAntesIva { get; set; }  
        public double ValorIva { get; set; }
        public double ValorAPagar { get; set; }

        public string Error { get; set; }
    }
}