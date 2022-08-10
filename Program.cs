using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string hello = "Hello";
      while (true)
      { 
        hello = hello + "o";
        Console.WriteLine(hello);
        Thread.Sleep(200);
      }
    }
  }
}