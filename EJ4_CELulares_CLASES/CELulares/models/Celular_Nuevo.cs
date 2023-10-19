using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CELulares.models
{
    internal class Celular_Nuevo : Celular
    {
        public DateOnly Fecha_Ingreso { get; set; }
        public decimal Precio { get; set; }

        public void mostrarCelulares(List<Celular_Nuevo> celulares)
        {
            int numero = 1;
            foreach (var item in celulares)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} - {5} - {6}",
                    numero++, "Marca " + item.Marca, "Modelo " + item.Modelo, "SO " + item.SO, "Almacenamiento " + item.Almacenamiento
                    , "Fecha de ingreso " + item.Fecha_Ingreso, "Precio " + item.Precio);
            }
        }
        public decimal Prom_Celular(List<Celular_Nuevo> celulares)
        {

            Func<List<Celular_Nuevo>, decimal> prom = l => l.Count == 0 ? 0 : l.Sum(c => c.Precio) / l.Count;
            return prom(celulares);
        }
        public void Cel_MarcaS(List<Celular_Nuevo> celulares, String marca)
        {
            var cel = celulares.Where(en => en.Marca == marca);
            int numero = 1;
            foreach (var en in cel)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} - {5} - {6}",
                                numero++, "Marca " + en.Marca, "Modelo " + en.Modelo, "SO " + en.SO, "Almacenamiento " + en.Almacenamiento
                                , "Fecha de ingreso " + en.Fecha_Ingreso, "Precio " + en.Precio);
            }

        }

        public void Celular_RSA(List<Celular_Nuevo> celulares, int ram,String so, int alm)
        {
            var en = from cel in celulares
                     where cel.RAM == ram && cel.Almacenamiento == alm && cel.SO == so   
                     select cel;
            int numero = 1;
            foreach (var cel in en)
            {
                
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} - {5} - {6}",
                                numero++, "Marca " + cel.Marca, "Modelo " + cel.Modelo, "SO " + cel.SO, "Almacenamiento " + cel.Almacenamiento
                                , "Fecha de ingreso " + cel.Fecha_Ingreso, "Precio " + cel.Precio);
            }

        }

        public void Celular_Ingreso(List<Celular_Nuevo> celulares,DateOnly fecha)
        {
            var en = from cel in celulares
                     where cel.Fecha_Ingreso == fecha
                     select cel;
            int numero = 1;
            foreach (var cel in en)
            {
                Console.WriteLine("{0}. {1} - {2} - {3} - {4} - {5} - {6}",
                                numero++, "Marca " + cel.Marca, "Modelo " + cel.Modelo, "SO " + cel.SO, "Almacenamiento " + cel.Almacenamiento
                                , "Fecha de ingreso " + cel.Fecha_Ingreso, "Precio " + cel.Precio);
            }
        }


    }
}
