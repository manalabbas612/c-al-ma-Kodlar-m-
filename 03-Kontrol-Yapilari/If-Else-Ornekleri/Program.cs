// If-Else Kontrol Yapıları Örnekleri
// If-Else Control Structures Examples

using System;

namespace IfElseOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== If-Else Kontrol Yapıları Örnekleri / If-Else Control Structures Examples ===");
            Console.WriteLine();
            
            // Örnek 1: Yaş Kontrolü
            YasKontrolu();
            
            Console.WriteLine("\n" + new string('-', 50) + "\n");
            
            // Örnek 2: Not Hesaplama
            NotHesaplama();
            
            Console.WriteLine("\n" + new string('-', 50) + "\n");
            
            // Örnek 3: Çift/Tek Sayı Kontrolü
            CiftTekKontrol();
            
            Console.ReadKey();
        }
        
        static void YasKontrolu()
        {
            Console.WriteLine("Örnek 1: Yaş Kontrolü / Example 1: Age Check");
            Console.Write("Yaşınızı girin / Enter your age: ");
            
            try
            {
                int yas = Convert.ToInt32(Console.ReadLine());
                
                if (yas < 0)
                {
                    Console.WriteLine("Geçersiz yaş! / Invalid age!");
                }
                else if (yas < 18)
                {
                    Console.WriteLine("Reşit değilsiniz. / You are a minor.");
                }
                else if (yas < 65)
                {
                    Console.WriteLine("Yetişkinsiniz. / You are an adult.");
                }
                else
                {
                    Console.WriteLine("Yaşlı bir biresiniz. / You are a senior citizen.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin! / Please enter a valid number!");
            }
        }
        
        static void NotHesaplama()
        {
            Console.WriteLine("Örnek 2: Not Hesaplama / Example 2: Grade Calculation");
            Console.Write("Notunuzu girin (0-100): / Enter your grade (0-100): ");
            
            try
            {
                double not = Convert.ToDouble(Console.ReadLine());
                
                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Geçersiz not! Not 0-100 arasında olmalı. / Invalid grade! Grade must be between 0-100.");
                }
                else if (not >= 90)
                {
                    Console.WriteLine("Harf Notu: AA - Mükemmel! / Letter Grade: AA - Excellent!");
                }
                else if (not >= 80)
                {
                    Console.WriteLine("Harf Notu: BA - Çok İyi! / Letter Grade: BA - Very Good!");
                }
                else if (not >= 70)
                {
                    Console.WriteLine("Harf Notu: BB - İyi! / Letter Grade: BB - Good!");
                }
                else if (not >= 60)
                {
                    Console.WriteLine("Harf Notu: CB - Orta / Letter Grade: CB - Average");
                }
                else if (not >= 50)
                {
                    Console.WriteLine("Harf Notu: CC - Geçer / Letter Grade: CC - Pass");
                }
                else
                {
                    Console.WriteLine("Harf Notu: FF - Kaldı / Letter Grade: FF - Fail");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin! / Please enter a valid number!");
            }
        }
        
        static void CiftTekKontrol()
        {
            Console.WriteLine("Örnek 3: Çift/Tek Sayı Kontrolü / Example 3: Even/Odd Number Check");
            Console.Write("Bir sayı girin / Enter a number: ");
            
            try
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                
                if (sayi % 2 == 0)
                {
                    Console.WriteLine($"{sayi} çift bir sayıdır. / {sayi} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{sayi} tek bir sayıdır. / {sayi} is an odd number.");
                }
                
                // Ek kontroller
                if (sayi > 0)
                {
                    Console.WriteLine("Pozitif sayı / Positive number");
                }
                else if (sayi < 0)
                {
                    Console.WriteLine("Negatif sayı / Negative number");
                }
                else
                {
                    Console.WriteLine("Sıfır / Zero");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin! / Please enter a valid number!");
            }
        }
    }
}
