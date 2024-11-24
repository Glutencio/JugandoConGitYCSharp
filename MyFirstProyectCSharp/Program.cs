using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProyectCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");
            string nombre;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Tu nombre es: {nombre}");

            int edad;
            Console.Write("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine($"La edad es {edad}");

            Console.ReadKey();
        }
    }
}
