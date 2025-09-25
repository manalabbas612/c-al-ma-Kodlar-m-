// Bu basit bir "Merhaba Dünya" örneğidir
// This is a simple "Hello World" example

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Türkçe selamlama
            Console.WriteLine("Merhaba Dünya!");
            Console.WriteLine("Hello World!");
            
            // Kullanıcıdan isim al
            Console.WriteLine("\nLütfen adınızı girin / Please enter your name:");
            string? name = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"Merhaba {name}! C# dünyasına hoş geldin!");
                Console.WriteLine($"Hello {name}! Welcome to the world of C#!");
            }
            
            Console.WriteLine("\nDevam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
