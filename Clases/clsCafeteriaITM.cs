using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_Palomino.Models;

namespace Servicios_Palomino.Clases
{
    public class clsCafeteriaITM
    {
        //Agregar propiedad del modelo CafeteriaITM
        public CafereriaITM cafereriaITM { get; set; }
        public void CalcularValorOriginal()
        {
            if (Validar())
            {
                cafereriaITM.Error = "";
                //Valor original

                cafereriaITM.ValorOriginal = cafereriaITM.ValorComboHyG * cafereriaITM.CantidadCombosHyG
                                             + cafereriaITM.ValorComboPayG * cafereriaITM.CantidadCombosPayG
                                             + cafereriaITM.ValorComboPeyG * cafereriaITM.CantidadCombosPeyG;


                //Calcula valor de descuento por cantidad total de combos
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
            double cantidadTotalCombos = cafereriaITM.CantidadCombosHyG + cafereriaITM.CantidadCombosPayG + cafereriaITM.CantidadCombosPeyG;
            if(cantidadTotalCombos > 2 && cantidadTotalCombos < 5)
            {
                cafereriaITM.ValorDescuento = cafereriaITM.ValorOriginal * cafereriaITM.Descuento3y4;
            }else if (cantidadTotalCombos > 4 && cantidadTotalCombos < 9)
            {
                cafereriaITM.ValorDescuento = cafereriaITM.ValorOriginal * cafereriaITM.Descuento5y8;
            }else if (cantidadTotalCombos > 8)
            {
                cafereriaITM.ValorDescuento = cafereriaITM.ValorOriginal * cafereriaITM.DecuentoMasDe8;
            }else
            {
                cafereriaITM.ValorDescuento = 0;
            }
        }
        private void CalcularValorAPagar()
        {
            cafereriaITM.ValorTotalAPagar = cafereriaITM.ValorOriginal-cafereriaITM.ValorDescuento;                               
        }
        private bool Validar()
        {
            bool continuar = true;
            cafereriaITM.Error = "";
            if (cafereriaITM.CantidadCombosHyG < 0)
            {
                cafereriaITM.Error = "La cantidad de combos de Hamburguesa y gaseosa debe ser mayor o igual a cero (0).";
                continuar = false;
            }
            if (cafereriaITM.CantidadCombosPayG < 0)
            {
                cafereriaITM.Error = "La cantidad de combos de Pastel y gaseosa debe ser mayor o igual a cero (0).";
                continuar = false;
            }
            if (cafereriaITM.CantidadCombosPeyG < 0)
            {
                cafereriaITM.Error = "La cantidad de combos de Perro y gaseosa debe ser mayor o igual a cero (0).";
                continuar = false;
            }
            return continuar;
        }

    }
}