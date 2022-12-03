using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace vsexam2
{
    class ThreadApp
    {
        private int[] data = new int[4];
        private int prod;
        public int this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public int PROD
        {
            get { return prod; }
            set { prod = value; }
        }
        public void ThreadProd(object seed)
        { // --- ①


            int rnd_seed = (int)seed;
            Random randomObj = new Random(rnd_seed);
            int result_temp = 1;


            for (int i = 0; i < 4; i++)
            {

                data[i] = randomObj.Next(rnd_seed);
                result_temp *= data[i];
                
                Thread.Sleep(1000);
            }

            PROD = result_temp;


        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine(" Seedvalue for Random class =" + args[0]);
            int i = int.Parse(args[0]);
            ThreadApp ta = new ThreadApp();
            Thread t = new Thread(ta.ThreadProd);
            t.Start(i);

            t.Join();
            Console.WriteLine("The accumlated product ={0}*{1}*{2}*{3}={4}" ,ta[0],ta[1] , ta[2] , ta[3] , ta.PROD);
        }
    }
}