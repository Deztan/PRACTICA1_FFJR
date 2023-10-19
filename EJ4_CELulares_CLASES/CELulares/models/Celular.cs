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

        public void mostrarCelular(List<Celular> celulares)
        {
            int numero = 1;
            foreach (var item in celulares)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} - {5}",
                    numero++, "Marca " + item.Marca, " Modelo " + item.Modelo, " SO " + item.SO, "Almacenamiento" + item.Almacenamiento);
            }
        }
    }

}
