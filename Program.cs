using System;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
         

            var a = Math.Pow(3.5 ,2);
            var b = Math.Pow(6 , 2);
            
            var c = Math.Sqrt(a + b);
            Console.WriteLine("długość przeciwprostokątnej wynosi:");
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
