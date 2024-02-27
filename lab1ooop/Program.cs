﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab1oop1
{
    class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {

            MyDelegate myDelegate1 = new MyDelegate(Timer.Method1);
            MyDelegate myDelegate2 = new MyDelegate(Timer.Method2);

      
            Thread thread1 = new Thread(new ThreadStart(myDelegate1.Invoke));
            Thread thread2 = new Thread(new ThreadStart(myDelegate2.Invoke));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

      
    }
}