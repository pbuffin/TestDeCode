using Kata.FizzBuzz.Models;
using System;

namespace Kata.FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(var number = 1; number<101; number++) { 
                var result = WholeNatural.Create(number).ToFizzBuzz();
                Console.WriteLine(result);
            
            }

            Console.ReadLine();
        }
    }
}
