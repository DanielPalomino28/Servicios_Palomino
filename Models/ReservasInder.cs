using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicios_Palomino.Models
{
    public class ReservasInder
    {
        public ReservasInder()
        {
            ValorHora = 50000;
            DescuentoHoras = 0.20;
            DescuentoDia = 0.40;
        }
        
        //Datos de entrada
        public int CantidadHoras { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string  DiaSemana { get; set; }
        //Datos de salida
        public double ValorReservaSinDescuento { get; set; }
        public double ValorDescuento { get; set; }
        public double ValorAPagar { get; set; }

        public string Error { get; set; }
        
        //Atributos
        public double ValorHora { get; set; }
        public double DescuentoHoras { get; set; }
        public double DescuentoDia { get; set; }
    }
}