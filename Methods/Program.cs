﻿using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Method();
            AsyncAwaitMethod();
            Camera.ResimKaydet();
            Camera.VideoKaydet();
            Camera.VideoKaydiDurdur();
            Console.ReadKey();

        }

         private static void Method()
        {
            Console.WriteLine("1");
            Task.Delay(1000);
            Console.WriteLine("2");
            Task.Delay(1000);
            Console.WriteLine("3");
            Task.Delay(1000);
        }
        async private static void AsyncAwaitMethod()
        {
            Console.WriteLine("4");
            await Task.Delay(1000);
            Console.WriteLine("5");
            await Task.Delay(1000);
            Console.WriteLine("6");
            await Task.Delay(1000);
        }
    }
}
