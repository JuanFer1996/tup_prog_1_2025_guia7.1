using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero");
            int numero = int.Parse(Console.ReadLine());
            
            int parteNumerica = numero % 1000;
            int parteLetrasNumero = numero / 1000;

            
            char letra1 = (char)('A' + (parteLetrasNumero / (26 * 26)) % 26);
            char letra2 = (char)('A' + (parteLetrasNumero / 26) % 26);
            char letra3 = (char)('A' + parteLetrasNumero % 26);

            Console.WriteLine(letra1+letra2+letra3+parteNumerica);

            Console.WriteLine($"{letra1}{letra2}{letra3}{parteNumerica:000}");
        }
    }
}
