using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad1,edad2,edad3,edad4;
            float monto,p1,p2,p3,p4,m1,m2,m3,m4;
            Console.WriteLine("Ingrese monto a repartir");
            monto=float.Parse(Console.ReadLine());

            Console.WriteLine("ingrese edad de las 4 niñas");
            edad1= int.Parse(Console.ReadLine());
            edad2= int.Parse(Console.ReadLine());
            edad3= int.Parse(Console.ReadLine());
            edad4= int.Parse(Console.ReadLine());

            int totaledad =edad1+edad2+edad3+edad4;
            p1= (edad1 / totaledad)*100;
            p2= (edad2 / totaledad)*100;
            p3= (edad3 / totaledad)*100;    
            p4= (edad4 /    totaledad)*100;

            m1 = ((p1 * monto) / 100);
            m2= ((p2 * monto) / 100);
            m3 = ((p3 * monto) / 100);
            m4 = ((p4 * monto) / 100);

            Console.WriteLine("porcentaje niña 1 "+p1+" monto: "+m1);
            Console.WriteLine("porcentaje niña 2 "+p2+" monto: "+m2);
            Console.WriteLine("porcentaje niña 3 "+p3+" monto: "+m3);
            Console.WriteLine("porcentaje niña 4 "+p4+" monto: "+m4);




        }
    }
}
