using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CELulares.models
{
    internal class Celular_Nuevo : Celular
    {
        public DateTime Fecha_Ingreso { get; set; }
        public decimal Precio { get; set; }

        public String mostrarCelular()
        {
            return "\nMarca=" + Marca + "\nModelo=" + Modelo + "\nSO=" + SO + "\nRAM="
                + RAM.ToString() + "\nAlmacenamiento=" + Almacenamiento;
        }
    }

}
