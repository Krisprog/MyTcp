using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTcp
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

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

            Person person = new Person();

        }
    }
}
