using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualexam1c
{
    class CONN<T>
    {
        public string Connect(int OP, T a, T b)
        {
            string aa = a.ToString();
            string bb = b.ToString();
            string c;
            if (OP == 0)
            {

                c = aa + bb;

            }
            else
            {
                c = bb + aa;
            }
            return c;
        }

    }
    class visual
    {
        public static void Main(string[] args)
        {
            CONN<Double> d = new CONN<double>();

            Console.Write("Read OP from keyboard ? :");
            int i;
            i = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                CONN<Int32> e = new CONN<Int32>();
                int a, b;

                Console.Write("Read int data(1) from keyboard ? :");
                a = int.Parse(Console.ReadLine());
                Console.Write("Read int data(2) from keyboard ? :");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine(e.Connect(i, a, b));


            }
            if (i == 1)
            {
                CONN<Double> e = new CONN<Double>();
                double a, b;

                Console.WriteLine("Read double data(1) from keyboard ? :");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Read double data(2) from keyboard ? :");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine(e.Connect(i, a, b));


            }
        }
    }
}