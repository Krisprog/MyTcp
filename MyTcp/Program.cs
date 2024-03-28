using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTcp
{
   namespace T
    {
        public class TServer
        { }
    }
    class Transport
    {
        public string Name {  get; set; }
        public int Port { get; set; }
        public Transport() { }  
        public Transport(int port) { }
 
    }   
    class Car:Transport { }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
           
         
           
        }
    }
}
