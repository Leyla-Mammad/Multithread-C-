using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string inputText = "Hello, World!";
        PrintText(inputText);
    }

    static void PrintText(string text)
    {
        foreach (char character in text)
        {
            Console.Write(character);
            Thread.Sleep(1000); 
        }

        Console.WriteLine();
    }
}