﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTcp
{
    class Transport
    {
        public string Name {  get; set; }
        public int Port { get; set; }
        public Transport() { }  
        public Transport(int port) { }
        public Transport(int port, string name) { }       
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            int[] mas = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }
            char[] chars = { 'a', 'b' };
           
        }
    }
}
