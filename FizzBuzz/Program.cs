using System;
using FizzBuzz.Lib;

namespace FizzBuzz.App
{
  class Program
  {
    static void Main()
    {
      var fizzbuzz = new FizzBuzzClass();
      for (var i = 1; i <= 100; i++)
      {
        fizzbuzz.Increment();
        Console.WriteLine(fizzbuzz.Write());
      }
      Console.ReadLine();
    }
  }
}
