using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace threds
{
    internal class Program
    {
        public static void func1()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(rnd.Next(1,100));
            }
        }
        public static void func2()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write((char)rnd.Next('A', 'Z'));
            }
        }
        public static void func3()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write((char)rnd.Next('a', 'z'));
            }
        }
        static void Main(string[] args)
        {
            Task[] taskts = 
            {
          Task.Run(func1),
          Task.Run(func2),
          Task.Run(func3),
              };
            Task.WaitAll(taskts);
            Console.WriteLine("finishAll");


        }
    }
}
