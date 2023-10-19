using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroLiteral.models
{
    internal static class Literal
    {
        public static String nlite(int num)
        {
            if (num < 0 || num > 999)
            {
                return "numero fuera del rango aceptado";
            }

            if (num == 0)
            {
                return "cero" ;
            }
            String[] unidad = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            String[] decena = { "", "diez", "veinte", "treinta", "cuareta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            String[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve" };

            int unidades = num % 10;
            int decenas = (num % 100) / 10;
            int centenas = num / 100;

            String resultado = "";
            if (centenas > 0)
            {
                if (centenas == 5)
                {
                    resultado += "quinientos";
                }
                else if (centenas == 9)
                {
                    resultado += "novecientos";
                }
                else
                {
                    resultado += unidad[centenas] + "cientos";
                }
            }
            if (decenas == 1)
            {
                resultado += " "+especiales[decenas];
            }
            else
            {
                resultado += " "+decena[decenas];

                if (unidades > 0)
                {
                    resultado += " y " + unidad[unidades];
                }
            }
            return resultado;
        }
    }
}
