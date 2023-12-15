using System;
using System.Collections.Generic;
using System.Linq;
using System.Text
using System.Threading;
using.System.Threading.Tasks;

namespace Loop 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.WriteLine("The time is: {0}", DateTime.Now.ToString());
                Thread.Sleep(1000);

                if (DateTime.Now.Second == 50) 
                {
                    isWorking = false;
                }
            }
        }
    }
}
