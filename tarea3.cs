using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, aux;
            byte i = 0, cont = 0;

            Stack pila = new Stack();

            Console.WriteLine("Ingrese 5 numeros enteros");

            for (i = 0; i < 5; i++)
            {
                aux = Convert.ToInt32(Console.ReadLine());
                pila.Push(aux);
            }



            Console.WriteLine("Contenido de la pila en orden inverso:");
            for (i = 0; i < 5; i++)
            {
                valor = Convert.ToInt32(pila.Pop());
                Console.WriteLine(valor);
            }
            Console.ReadKey();
        }
    }
}
