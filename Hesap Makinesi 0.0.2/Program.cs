using System;

namespace Hesap_Makinesi_0._0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double x = 0;
            double y = 0;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Ultra Epik Hesap Makinesi v0.0.2");
            Console.WriteLine("----------------------------------------------------");
            do
            {
                try
                {
                    Console.Write("İlk numarayı yaz: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("İkinci numarayı yaz: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("--İşlemi yaz!--");
                    Console.WriteLine("\t+ : Toplama");
                    Console.WriteLine("\t- : Çıkarma");
                    Console.WriteLine("\t* : Çarpma");
                    Console.WriteLine("\t/ : Bölme");
                    Console.WriteLine("\t% : Yüzdelik");
                    Console.WriteLine("\t! : Bölme Kalanı");

                    switch (Console.ReadLine())
                    {
                        case "+":
                            result = x + y;
                            Console.WriteLine($"Sonuç: {x} + {y} = " + result);
                            break;
                        case "-":
                            result = x - y;
                            Console.WriteLine($"Sonuç: {x} - {y} = " + result);
                            break;
                        case "*":
                            result = x * y;
                            Console.WriteLine($"Sonuç: {x} * {y} = " + result);
                            break;
                        case "/":
                            result = x / y;
                            Console.WriteLine($"Sonuç: {x} / {y} = " + result);
                            break;
                        case "%":
                            result = x * y / 100;
                            Console.WriteLine($"Sonuç: {x}'in %{y}'si = " + result);
                            break;
                        case "!":
                            result = x % y;
                            Console.WriteLine($"Sonuç: {x} ile {y}'yi böldükten sonra kalan = " + result);
                            break;
                        default:
                            Console.WriteLine("Seçenek geçersiz");
                            break;
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("[!!!UYARI!!!] Böyle bir şey yazamazsın! Yeniden dene!");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!!!UYARI!!!] Hata! Yeniden dene!");
                }

                Console.WriteLine("Yeniden denemek ister misin?");
                Console.WriteLine("E : Evet");
                Console.WriteLine("H : Hayır");
            } while (Console.ReadLine().ToUpper() == "E");


            Console.ReadKey();
        }
    }
}