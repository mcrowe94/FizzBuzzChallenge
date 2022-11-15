using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace FizzBuzzChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a public method that accepts a number
            //when the number is divisible by 3 return the word fizz

            //when the number is divisible by 5 return the word buzz

            //when the number is divisible by both, return the word fizzbuzz




            for (int i = 1; i <= 100; i++)//loop counts to 100 looking for numbers divisible by 3, 5, or both
            {
                FizzBuzz(i);//number currently looping on
            }
        }

        public static void FizzBuzz(int num)
        {
            if(num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine($"{num} FizzBuzz!!!");//numbers ARE DIVISIBLE by 3 & 5
            }
            else if(num % 3 == 0)
            {
                Console.WriteLine($"{num} Fizz!");//number IS DIVISIBLE by 3
            }
          
            else if(num % 5 == 0)
            {
                Console.WriteLine($"{num} Buzz!");//number IS DIVISIBLE by 5
            }
            else
            {
                Console.WriteLine($"{num} is not divisible by 3 or 5!");//number ARE NOT DIVISIBLE by 3 or 5
            }
        }
    }
}