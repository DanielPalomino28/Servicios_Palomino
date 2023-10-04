using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsSeguroVehiculos
    {
        //Agregar propiedad del modelo CafeteriaITM
        public SeguroVehiculos seguroVehiculos { get; set; }
        public void CalcularValorBase()
        {
            if (Validar())
            {
                seguroVehiculos.Error = "";
                //Valor base
                if (seguroVehiculos.ReclamacionesAnioAnterior == 1)
                {
                    seguroVehiculos.ValorBase = seguroVehiculos.ValorComercial * seguroVehiculos.UnaReclamacion;
                }
                else if (seguroVehiculos.ReclamacionesAnioAnterior == 2)
                {
                    seguroVehiculos.ValorBase = seguroVehiculos.ValorComercial * seguroVehiculos.DosReclamaciones;
                }
                else if (seguroVehiculos.ReclamacionesAnioAnterior == 3)
                {
                    seguroVehiculos.ValorBase = seguroVehiculos.ValorComercial * seguroVehiculos.TresReclamaciones;
                }
                else
                {
                    seguroVehiculos.ValorBase = seguroVehiculos.ValorComercial * seguroVehiculos.CuatroOMasReclamaciones;
                }
                //Calcula valor de descuento por cantidad total de combos
                CalcularIncremento();
                //Calcula el valor antes de Iva
                CalcularValorAntesDeIva();
                //Calcula el valor de Iva
                CalcularValorIva();
                //Calcula el valor a pagar
                CalcularValorAPagar();
            }
            else
            {
                //Paro el proceso
                return;
            }
        }
        private void CalcularIncremento()
        {            
            if(seguroVehiculos.ReclamacionesAnioAnterior == 1)
            {
                seguroVehiculos.ValorIncremento = seguroVehiculos.ValorBase * seguroVehiculos.UnaReclamacion;
            }else if (seguroVehiculos.ReclamacionesAnioAnterior == 2)
            {
                seguroVehiculos.ValorIncremento = seguroVehiculos.ValorBase * seguroVehiculos.DosReclamaciones;
            }else if (seguroVehiculos.ReclamacionesAnioAnterior == 3)
            {
                seguroVehiculos.ValorIncremento = seguroVehiculos.ValorBase * seguroVehiculos.TresReclamaciones;
            }
            else
            {
                seguroVehiculos.ValorIncremento = seguroVehiculos.ValorBase * seguroVehiculos.CuatroOMasReclamaciones;
            }
        }

        private void CalcularValorAntesDeIva()
        {
            seguroVehiculos.ValorAntesIva = (seguroVehiculos.ValorBase + seguroVehiculos.ValorIncremento) / (1 + seguroVehiculos.PorcentajeIva);
        }

        private void CalcularValorIva()
        {
            seguroVehiculos.ValorIva = (seguroVehiculos.ValorBase + seguroVehiculos.ValorIncremento) - seguroVehiculos.ValorAntesIva;
        }

        private void CalcularValorAPagar()
        {
            seguroVehiculos.ValorAPagar = seguroVehiculos.ValorBase + seguroVehiculos.ValorIncremento;
        }
        private bool Validar()
        {
            bool continuar = true;
            seguroVehiculos.Error = "";
            if (seguroVehiculos.ValorComercial <= 0)
            {
                seguroVehiculos.Error = "El valor comercial debe ser mayor a 0.";
                continuar = false;
            }
            if (seguroVehiculos.ReclamacionesAnioAnterior <= 0)
            {
                seguroVehiculos.Error += "\n" + "La cantidad de reclamaciones debe ser mayor a cero (0).";
                continuar = false;
            }
            return continuar;
        }

    }
}