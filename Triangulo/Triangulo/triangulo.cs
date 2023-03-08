using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    public class triangulo
    {
        public void Triangulo(string[] args)
        {
            Console.Write("Introduce un número entero para la altura");
            int altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
