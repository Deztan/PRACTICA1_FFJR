using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELulares.models
{
    abstract class Celular
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String SO { get; set; }
        public int RAM { get; set; }
        public int Almacenamiento { get; set; }
        
        public String mostrarCelular() 
        {
            return "\nMarca=" + Marca + "\nModelo=" + Modelo + "\nSO=" + SO + "\nRAM="
                + RAM.ToString() + "\nAlmacenamiento=" + Almacenamiento;
        }
    }

}
