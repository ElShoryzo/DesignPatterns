﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
        public void Method()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
