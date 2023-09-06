using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsServiciosEpm
    {
        //Agregar propiedad del modelo Reservas
        public ServiciosEpm serviciosEpm { get; set; }
        public void CalcularValoresTotales()
        {
            if (Validar())
            {
                serviciosEpm.Error = "";
                //Valor total por servicio

                serviciosEpm.ValorTotalAgua = serviciosEpm.ConsumoAgua * serviciosEpm.ValorAgua;
                serviciosEpm.ValorTotalGas = serviciosEpm.ConsumoGas * serviciosEpm.ValorGas;
                serviciosEpm.ValorTotalEnergia = serviciosEpm.ConsumoEnergia * serviciosEpm.ValorEnergia;
                
                //Valor total sin descuento
                serviciosEpm.ValorTotalSinDescuento = serviciosEpm.ValorTotalAgua+ serviciosEpm.ValorTotalGas+ serviciosEpm.ValorTotalEnergia;

                //Calcula valor de los descuentos por servicio
                CalcularDescuentos();
                //Calcula valor de los recargos por servicio
                CalcularRecargos();
                //Calcula el valor a pagar
                CalcularValorAPagar();
            }
            else
            {
                //Paro el proceso
                return;
            }
        }
        private void CalcularDescuentos()
        {
            double DescuentoAgua = 0;
            double DescuentoGas = 0;
            double DescuentoEnergia = 0;

            if (serviciosEpm.ConsumoAgua < 15)
            {
                DescuentoAgua = (serviciosEpm.ConsumoAgua * serviciosEpm.ValorAgua) * serviciosEpm.BeneficioAgua;
            }
            if (serviciosEpm.ConsumoGas < 20)
            {
                DescuentoGas = (serviciosEpm.ConsumoGas * serviciosEpm.ValorGas) * serviciosEpm.BeneficioGas;
            }
            if (serviciosEpm.ConsumoEnergia < 50)
            {
                DescuentoEnergia = (serviciosEpm.ConsumoEnergia * serviciosEpm.ValorEnergia) * serviciosEpm.BeneficioEnergia;
            }
            serviciosEpm.ValorDescuento = DescuentoAgua + DescuentoGas + DescuentoEnergia;
        }
        private void CalcularRecargos()
        {
            double RecargoAgua = 0;
            double RecargoGas = 0;
            double RecargoEnergia = 0;

            if (serviciosEpm.ConsumoAgua > 25)
            {
                RecargoAgua = (serviciosEpm.ConsumoAgua * serviciosEpm.ValorAgua) * serviciosEpm.RecargoAgua;
            }
            if (serviciosEpm.ConsumoGas > 40)
            {
                RecargoGas = (serviciosEpm.ConsumoGas * serviciosEpm.ValorGas) * serviciosEpm.RecargoGas;
            }
            if (serviciosEpm.ConsumoEnergia > 80)
            {
                RecargoEnergia = (serviciosEpm.ConsumoEnergia * serviciosEpm.ValorEnergia) * serviciosEpm.RecargoEnergia;
            }
            serviciosEpm.ValorRecargo = RecargoAgua + RecargoGas + RecargoEnergia;
        }
        private void CalcularValorAPagar()
        {
            serviciosEpm.ValorTotalAPagar = serviciosEpm.ValorTotalSinDescuento 
                                            -serviciosEpm.ValorDescuento
                                            +serviciosEpm.ValorRecargo;                               
        }
        private bool Validar()
        {
            bool continuar = true;
            serviciosEpm.Error = "";
            if (serviciosEpm.ConsumoAgua < 0)
            {
                serviciosEpm.Error = "El consumo de agua debe ser mayor o igual a 0.";
                continuar = false;
            }
            if (serviciosEpm.ConsumoGas < 0)
            {
                serviciosEpm.Error += "\nEl consumo de gas debe ser mayor o igual a 0.";
                continuar = false;
            }
            if (serviciosEpm.ConsumoEnergia < 0)
            {
                serviciosEpm.Error += "\nEl consumo de energia debe ser mayor o igual a 0.";
                continuar = false;
            }
            return continuar;
        }

    }
}