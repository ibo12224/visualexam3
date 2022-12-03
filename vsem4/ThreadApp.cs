using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
