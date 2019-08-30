using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzFuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] FizzBuzzArray = new int[101];
            for (int i = 0; i < FizzBuzzArray.Length; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                Console.WriteLine(i);
                
            }


            Console.ReadKey();
        }
    }
}
