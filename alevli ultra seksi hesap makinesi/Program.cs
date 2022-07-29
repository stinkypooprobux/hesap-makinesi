using System;

namespace alevli_ultra_seksi_hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 1;
            double x = 0;
            double y = 0;
            
            double pi = Math.PI;

            char qmark = '?';
            
            string exponential = $"{x * x }"; //ekstra kullanılmayan fonksiyonlar
            double a = 0;
            double amongus = 0;
            double b = y-1;
            double z = 0;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Ultra Epik Hesap Makinesi v0.0.2");
            Console.WriteLine("----------------------------------------------------");
            do
            {
                try
                {
                    Console.Write($"İlk numarayı yaz: ");
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
                    Console.WriteLine("\tx : Üslü İfadeler");
                    Console.WriteLine("\t; : Kök İfadeleri");
                    Console.WriteLine("\tsin : sin(x)");
                    Console.WriteLine("\tcos : cos(x)");
                    Console.WriteLine("\ttan : tan(x)");

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
                        case "x":
                            result = Math.Pow(x, y);
                            Console.WriteLine($"Sonuç: {x} üssü {y} = "+result);
                            break;
                        case ";": //isteğe bağlı "y" buradan itibaren başlıyor.
                            result = Math.Sqrt(x);
                            Console.WriteLine($"Sonuç: {x} sayısının karekökü = "+result);
                            break;
                        case "sin":
                            result = Math.Sin(x);
                            Console.WriteLine($"Sonuç: sin({x}) = " + result);
                            break;
                        case "cos":
                            result = Math.Cos(x);
                            Console.WriteLine($"Sonuç: cos({x}) = " + result);
                            break;
                        case "tan":
                            result = Math.Tan(x);
                            Console.WriteLine($"Sonuç: tan({x}) = " + result);
                            break;
                        default:
                            Console.WriteLine("[!!!UYARI!!!] Seçenek geçersiz!");
                            break;
                    }

                    //  if (qmark == Convert.ToChar(result))    |    Kullanılmayan fonksiyon.
                    //  {
                    //      Console.WriteLine("[!!!UYARI!!!] Sonuç bulunamadı."); 
                    //  }

                } //Çökmeden kurtaran reyizler
                

                catch (FormatException)
                {
                    Console.WriteLine("[!!!HATA!!!] Böyle bir şey yazamazsın! Yeniden dene!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("[!!!HATA!!!] Bir sayıyı sıfıra bölemezsin, salak!");
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("[!!!HATA!!!] Aritmetik hata!");
                }
                catch (AccessViolationException)
                {
                    Console.WriteLine("[!!!HATA!!!] Sadece erişebileceğin işlemleri yap!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("[!!!HATA!!!] Argüman hatası, yeniden dene!");
                }
                
                catch (Exception) //belirlenmemiş hataların bulundurulduğu yer
                {
                    Console.WriteLine("[!!!HATA!!!] Belirlenmemiş hata!");
                }



                Console.WriteLine("Yeniden denemek ister misin?");
                Console.WriteLine("E : Evet");
                Console.WriteLine("H : Hayır");
            } while (Console.ReadLine().ToUpper() == "E");


            Console.ReadKey();
        }
    }
}
