using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsReservasInder
    {
        //Agregar propiedad del modelo Reservas
        public ReservasInder reservasInder { get; set; }
        public void CalcularValorSinDescuento()
        {
            if (Validar())
            {   
               
                //Continuo
                double valorSinDescuento = reservasInder.ValorHora * reservasInder.CantidadHoras;
                reservasInder.ValorReservaSinDescuento = valorSinDescuento;
                //Calcula valor del descuento
                CalcularDescuento();
                //Calcula el valor a pagar
                CalcularValorAPagar();
            }
            else
            {
                //Paro el proceso
                return;
            }
        }
        private void CalcularDescuento()
        {
            double Descuento = 0;
            if (reservasInder.CantidadHoras > 2)
            {
                Descuento = reservasInder.ValorReservaSinDescuento * reservasInder.DescuentoHoras;
            }
            if(reservasInder.DiaSemana!="Sabado" && reservasInder.DiaSemana != "Domingo")
            {
                Descuento += reservasInder.ValorReservaSinDescuento * reservasInder.DescuentoDia;
            }
            reservasInder.ValorDescuento = Descuento;
        }
        private void CalcularValorAPagar()
        {
            reservasInder.ValorAPagar = reservasInder.ValorReservaSinDescuento-reservasInder.ValorDescuento;
        }
        private bool Validar()
        {
            bool continuar = true;
            reservasInder.Error = "";
            if (reservasInder.CantidadHoras < 1 || reservasInder.CantidadHoras > 24)
            {
                reservasInder.Error = "Las horas a reservar deben estar entre 0 y 24.";
                continuar = false;
            }
            return continuar;
        }

    }
}