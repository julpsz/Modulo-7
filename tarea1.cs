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
            float aux =0;
            byte i = 0;

            Queue cola = new Queue();

            Console.WriteLine("Ingrese 5 numeros reales");

            for(i=0;i<5;i++)
            { 
            aux = Convert.ToSingle(Console.ReadLine());
            cola.Enqueue(aux);
            }

            Console.WriteLine("Contenido acumulado en la cola");
            for (i = 0; i < 5; i++)
            {
                aux = Convert.ToSingle(cola.Dequeue());
                Console.WriteLine(aux);
            }
            Console.ReadKey();
        }
    }
}
