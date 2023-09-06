using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Models
{
    public class ServiciosEpm
    {
        public ServiciosEpm()
        {
            ValorAgua = 1500;
            ValorGas = 1200;
            ValorEnergia = 950;
            BeneficioAgua = 0.1;
            BeneficioGas = 0.15;
            BeneficioEnergia = 0.2;
            RecargoAgua = 0.2;
            RecargoGas = 0.35;
            RecargoEnergia = 0.25;
        }

        //Atributos
        public double ValorAgua { get; set; }
        public double ValorGas { get; set; }
        public double ValorEnergia { get; set; } 

        public double BeneficioAgua { get; set; }
        public double BeneficioGas { get; set; }
        public double BeneficioEnergia { get; set; }
        public double RecargoAgua { get; set; }
        public double RecargoGas { get; set; }
        public double RecargoEnergia { get; set; }

        //Datos de entrada
        public double ConsumoAgua { get; set; }
        public double ConsumoGas { get; set; }
        public double ConsumoEnergia { get; set; }
        //Datos de salida
        public double ValorTotalAgua { get; set; }
        public double ValorTotalGas { get; set; }
        public double ValorTotalEnergia { get; set; }
        public double ValorTotalSinDescuento { get; set; }
        public double ValorDescuento { get; set; }
        public double ValorRecargo { get; set; }
        public double ValorTotalAPagar { get; set; }
        public string Error { get; set; }
        
    }
}