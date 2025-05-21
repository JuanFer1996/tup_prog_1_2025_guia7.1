using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float masa, cantidadBudines, cantCajas,cantPaquetes,cantpaqueteSobrantes,masaSobrante;
            Console.WriteLine("Ingrese cantidad de masa a producir en kg");
            masa=int.Parse(Console.ReadLine());
            masa *= 1000;
            cantidadBudines = masa/55;
            masaSobrante = masa % 55;
            cantPaquetes = cantidadBudines / 12;
            cantpaqueteSobrantes = cantidadBudines % 12;    
            cantCajas = cantPaquetes / 20;

            Console.WriteLine($"Cantidad de budines: {cantidadBudines:F0}"); 
            Console.WriteLine("Cantidad de budines: " + Math.Truncate(cantidadBudines));
            Console.WriteLine("Masa sobrante: " + Math.Truncate(masaSobrante)+ " gr");
            Console.WriteLine("Cantidad de paquetes: " + Math.Truncate(cantPaquetes));
            Console.WriteLine("Cantidad de cajas completas: " + Math.Truncate(cantCajas));
            Console.WriteLine("Cantidad de paquetes sobrantes: " + Math.Truncate(cantpaqueteSobrantes));

        }
    }
}
