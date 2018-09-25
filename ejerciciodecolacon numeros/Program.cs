using System;
using System.Collections;

namespace ejerciciodecolacon_numeros
{
    public class Program
    {
        public static void Main()
        {
            Double minumero;
            Queue laCola = new Queue();
            laCola.Enqueue(1.22);
            laCola.Enqueue(2.19);
            laCola.Enqueue(3.78);
            laCola.Enqueue(4.408);
            laCola.Enqueue(5.601);
            for (byte i = 0; i < 5; i++)
            {
                minumero = (Double)laCola.Dequeue();
                Console.WriteLine(minumero);
                Console.ReadKey();


            }
        }
    }
}
