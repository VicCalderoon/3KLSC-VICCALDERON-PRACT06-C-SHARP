using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> aves = new List<string> { "Loro gris, ", "Paloma de diamante, ", "Cóctel, " };
            Console.WriteLine("Los valores de la lista antes de insertar: ");
            foreach (string ave in aves)
            {
                Console.Write(ave + " ");
            }
        }
    }
}