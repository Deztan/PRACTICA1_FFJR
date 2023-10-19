using CELulares.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Celular_Nuevo> msm = new List<Celular_Nuevo>()
        {
            new Celular_Nuevo() { Marca="Samsung" ,Modelo ="a55", SO = "Android",RAM = 8 ,Almacenamiento = 128,Fecha_Ingreso = new DateOnly(2001,9,11) ,Precio = 1834m},
            new Celular_Nuevo() { Marca="Apple" ,Modelo ="iphone9", SO = "IOS",RAM = 16 ,Almacenamiento = 32,Fecha_Ingreso = new DateOnly(2005,5,8) ,Precio = 1190m},
            new Celular_Nuevo() { Marca="Xiaomi" ,Modelo ="redmi9", SO = "Android",RAM = 8 ,Almacenamiento = 32,Fecha_Ingreso = new DateOnly(2008,9,1) ,Precio = 1100m},
            new Celular_Nuevo() { Marca="Huawei" ,Modelo ="p30", SO = "Android",RAM = 8 ,Almacenamiento = 128,Fecha_Ingreso = new DateOnly(2003,1,23) ,Precio = 1123m},
            new Celular_Nuevo() { Marca="Sansung" ,Modelo ="j5", SO = "Android",RAM = 4 ,Almacenamiento = 8,Fecha_Ingreso = new DateOnly(2001,8,12) ,Precio = 1124m},
            new Celular_Nuevo() { Marca="Samsung" ,Modelo ="galaxi10", SO = "Android",RAM = 16 ,Almacenamiento = 128,Fecha_Ingreso = new DateOnly(2001,6,7) ,Precio = 1170m},
            new Celular_Nuevo() { Marca="Tecno" ,Modelo ="pova5", SO = "Android",RAM = 16 ,Almacenamiento = 64,Fecha_Ingreso = new DateOnly(2005,7,19) ,Precio = 1130m},
            new Celular_Nuevo() { Marca="Xiaomi" ,Modelo ="redmi8", SO = "Android",RAM = 8 ,Almacenamiento = 128,Fecha_Ingreso = new DateOnly(2001,9,11) ,Precio = 1234m},
            new Celular_Nuevo() { Marca="LG" ,Modelo ="g6", SO = "Android",RAM = 2 ,Almacenamiento = 8,Fecha_Ingreso = new DateOnly(2002,4,10) ,Precio = 830m},
            new Celular_Nuevo() { Marca="Apple" ,Modelo ="iphone10", SO = "IOS",RAM = 32 ,Almacenamiento = 128,Fecha_Ingreso = new DateOnly(2009,5,17) ,Precio = 2034m},

        };

        Celular_Nuevo celu = new Celular_Nuevo();
        celu.mostrarCelulares(msm);
        Console.WriteLine();
        Console.WriteLine("Promedio de precios = "+celu.Prom_Celular(msm));
        Console.WriteLine("\nCelulares encontrados con la marca ingresada\n");
        celu.Cel_MarcaS(msm,"Samsung");
        Console.WriteLine("\nCelulares encontrados con la ram,so y almacenamiento ingresado\n");
        celu.Celular_RSA(msm,8,"Android",128);
        Console.WriteLine("\ncelulares añadidos en una fecha dada\n");
        celu.Celular_Ingreso(msm,new DateOnly(2001,9,11));
    }
}