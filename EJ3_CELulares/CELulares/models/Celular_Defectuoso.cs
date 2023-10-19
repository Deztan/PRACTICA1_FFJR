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
    internal class Celular_Defectuoso:Celular
    {
        public DateTime Fecha_Defecto { get; set; }
        public String Motivo { get; set; }

        public String mostrarCelular()
        {
            return "\nMarca=" + Marca + "\nModelo=" + Modelo + "\nSO=" + SO + "\nRAM="
                + RAM.ToString() + "\nAlmacenamiento=" + Almacenamiento;
        }
    }
}
