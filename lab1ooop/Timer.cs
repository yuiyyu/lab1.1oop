using System;
using System.Threading;


namespace Lab1oop1
{
    class Timer
    {
        public static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"номер потоку: {Thread.CurrentThread.ManagedThreadId} - {DateTime.Now} - Method1 виконаний");
               
            }            
        }

        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine($"номер потоку: {Thread.CurrentThread.ManagedThreadId} - {DateTime.Now} - Method2 виконаний");
                
            } 
        }
    }
}