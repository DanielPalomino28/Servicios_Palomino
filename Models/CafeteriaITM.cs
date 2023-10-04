using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Models
{
    public class CafereriaITM
    {
        public CafereriaITM()
        {
            ValorComboHyG = 8000;
            ValorComboPeyG = 6000;
            ValorComboPayG = 4500;
            Descuento3y4 = 0.1;
            Descuento5y8 = 0.2;
            DecuentoMasDe8 = 0.3;
        }

        //Atributos
        public double ValorComboHyG { get; set; }
        public double ValorComboPeyG { get; set; }
        public double ValorComboPayG { get; set; } 
        public double Descuento3y4 { get; set; }
        public double Descuento5y8 { get; set; }
        public double DecuentoMasDe8 { get; set; }

        //Datos de entrada
        public double CantidadCombosHyG { get; set; }
        public double CantidadCombosPeyG { get; set; }
        public double CantidadCombosPayG { get; set; }

        //Datos de salida
        public double ValorOriginal { get; set; }
        public double ValorDescuento { get; set; }
        public double ValorTotalAPagar { get; set; }  
        public string Error { get; set; }
    }
}