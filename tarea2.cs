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
            string nombre = "0", aux = "0";
            byte i = 0, cont =0;

            Queue cola = new Queue();

            Console.WriteLine("Ingrese frases");

            do
            {
                aux = Console.ReadLine();
                if (aux != "")
                {
                    cola.Enqueue(aux);
                    cont++;
                }
            } while (aux != "");

            Console.WriteLine("Contenido de la cola:");
            for (i = 0; i < cont; i++)
            {
                nombre = Convert.ToString(cola.Dequeue());
                Console.WriteLine(nombre);
            }
            Console.ReadKey();
        }
    }
}
