// Basit Hesap Makinesi Örneği
// Simple Calculator Example

using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Basit Hesap Makinesi / Simple Calculator ===");
            Console.WriteLine();
            
            bool devamEt = true;
            
            while (devamEt)
            {
                try
                {
                    // İlk sayıyı al
                    Console.Write("Birinci sayıyı girin / Enter first number: ");
                    double sayi1 = Convert.ToDouble(Console.ReadLine());
                    
                    // İşlem türünü al
                    Console.Write("İşlem seçin (+, -, *, /) / Choose operation (+, -, *, /): ");
                    string? islem = Console.ReadLine();
                    
                    // İkinci sayıyı al
                    Console.Write("İkinci sayıyı girin / Enter second number: ");
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    
                    double sonuc = 0;
                    bool gecerliIslem = true;
                    
                    // İşlemi gerçekleştir
                    switch (islem)
                    {
                        case "+":
                            sonuc = sayi1 + sayi2;
                            break;
                        case "-":
                            sonuc = sayi1 - sayi2;
                            break;
                        case "*":
                            sonuc = sayi1 * sayi2;
                            break;
                        case "/":
                            if (sayi2 != 0)
                            {
                                sonuc = sayi1 / sayi2;
                            }
                            else
                            {
                                Console.WriteLine("Hata: Sıfıra bölme hatası! / Error: Division by zero!");
                                gecerliIslem = false;
                            }
                            break;
                        default:
                            Console.WriteLine("Geçersiz işlem! / Invalid operation!");
                            gecerliIslem = false;
                            break;
                    }
                    
                    if (gecerliIslem)
                    {
                        Console.WriteLine($"Sonuç / Result: {sayi1} {islem} {sayi2} = {sonuc}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hata: Lütfen geçerli bir sayı girin! / Error: Please enter a valid number!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bir hata oluştu / An error occurred: {ex.Message}");
                }
                
                Console.WriteLine();
                Console.Write("Devam etmek istiyor musunuz? (e/h) / Continue? (y/n): ");
                string? cevap = Console.ReadLine()?.ToLower();
                devamEt = (cevap == "e" || cevap == "y" || cevap == "evet" || cevap == "yes");
                Console.WriteLine();
            }
            
            Console.WriteLine("Hesap makinesi kapanıyor... / Calculator closing...");
            Console.WriteLine("Teşekkürler! / Thank you!");
        }
    }
}
