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
            double percentile = 0;

            double b = y - 1;
            double pi = Math.PI;

            string selectablevariable = "";
            double variable = 0;
            double xpow2 = x * x;

            char qmark = '?'; //kullanılmayan değişkenler
            double z = 0;
            string exponential = $"{x * x }"; //genel değişkenler
            double a = 0;
            double amongus = 0;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Ultra Epik Hesap Makinesi v0.0.4");
            Console.WriteLine("----------------------------------------------------");
            do
            {
                try
                {
                    Console.Write($"İlk numarayı yaz: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"İkinci numarayı yaz: ");
                    y = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"Değiştirilebilir yüzdeyi yaz: ");
                    percentile = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"Değişken yaz (wikiye bak.): ");
                    selectablevariable = Console.ReadLine();

                    //değişkenler wuhuuu
                    if (selectablevariable == "pi") 
                    {
                        variable = pi;
                    }
                    else if (selectablevariable == "yminusx")
                    {
                        variable = y - x;
                    }
                    else if (selectablevariable == "xminusy")
                    {
                        variable = x - y;
                    }
                    else if (selectablevariable == "zero")
                    {
                        variable = 0;
                    }
                    else if (selectablevariable == "")
                    {
                        variable = variable;
                    }
                    else if (selectablevariable == "one")
                    {
                        variable = 1;
                    }
                    else if (selectablevariable == "roundenv")
                    {
                        variable = 2 * pi * x;
                    }
                    else if (selectablevariable == "roundenvy")
                    {
                        variable = percentile * pi * x;
                    }
                    else if (selectablevariable == "roundarea")
                    {
                        variable = pi * xpow2;
                    }
                    //tam sayı sınırları
                    else if (selectablevariable == "64bitint")
                    {
                        variable = 9223372036854775807;
                    }
                    else if (selectablevariable == "32bitint")
                    {
                        variable = 2147483647;
                    }
                    else if (selectablevariable == "16bitint")
                    {
                        variable = 32767;
                    }
                    //şaka değişkenler
                    else if (selectablevariable == "yarrak")
                    {
                        variable = 31;
                    }
                    else if (selectablevariable == "am")
                    {
                        variable = 52;
                    }
                    else if (selectablevariable == "sex")
                    {
                        variable = 69;
                    }
                    else if (selectablevariable == "funny")
                    {
                        variable = 420;
                    }
                    else if (selectablevariable == "sexfunny")
                    {
                        variable = 69420;
                    }
                    else if (selectablevariable == "annem")
                    {
                        variable = 69;
                        Console.Write("\tNeden siktiğim kişiyi değişken olarak yazıyorsun?\n");
                    }
                    else if (selectablevariable == "amongus")
                    {
                        variable = 52;
                        Console.Write("\tsus\n");
                    }
                    else if (selectablevariable == "uselessshit")
                    {
                        variable = variable;
                    }
                    else if (selectablevariable == "formatexception")
                    {
                        variable = Convert.ToDouble(selectablevariable);
                    }



                    Console.WriteLine("--İşlemi yaz!--");
                    Console.WriteLine("\t+ : Toplama (Değişken Geçerli)");
                    Console.WriteLine("\t- : Çıkarma (Değişken Geçerli)");
                    Console.WriteLine("\t* : Çarpma (Değişken Geçerli)");
                    Console.WriteLine("\t/ : Bölme (Değişken Geçerli)");
                    Console.WriteLine("\t% : Yüzdelik İfadeleri");
                    Console.WriteLine("\t%% : Çeşitli Yüzdelik İfadeleri");
                    Console.WriteLine("\t! : Bölme Kalanı");
                    Console.WriteLine("\tx : Üslü İfadeler");
                    Console.WriteLine("\t; : Kök İfadeleri");
                    Console.WriteLine("\tsin : Sinüs");
                    Console.WriteLine("\tcos : Kosinüs");
                    Console.WriteLine("\ttan : Teğet");
                    Console.WriteLine("\tvar : Değişken");

                    switch (Console.ReadLine())
                    {
                        case "+"://normal işlemler
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
                        case "var":
                            result = variable;
                            Console.WriteLine($"Sonuç: {selectablevariable} = " + result);
                            break;

                        case "%": //yüzdelik ifadeleri
                            result = x * y / 100;
                            Console.WriteLine($"Sonuç: {x}'in yüzde {y}'si = " + result);
                            break;
                        case "%%":
                            result = x * y / percentile;
                            Console.WriteLine($"Sonuç: {x}'in {percentile}de {y}'si = " + result);
                            break;

                        case "++"://+ değişken işlemleri
                            result = x + y + variable;
                            Console.WriteLine($"Sonuç: {x} + {y} + {selectablevariable} = " + result);
                            break;
                        case "-+":
                            result = x - y + variable;
                            Console.WriteLine($"Sonuç: {x} - {y} + {selectablevariable} = " + result);
                            break;
                        case "*+":
                            result = x * y + variable;
                            Console.WriteLine($"Sonuç: {x} * {y} + {selectablevariable} = " + result);
                            break;
                        case "/+":
                            result = x / y + variable;
                            Console.WriteLine($"Sonuç: {x} / {y} + {selectablevariable} = " + result);
                            break;
                        
                        case "+-"://- değişken işlemleri
                            result = x + y - variable;
                            Console.WriteLine($"Sonuç: {x} + {y} - {selectablevariable} = " + result);
                            break;
                        case "--":
                            result = x - y - variable;
                            Console.WriteLine($"Sonuç: {x} - {y} - {selectablevariable} = " + result);
                            break;
                        case "*-":
                            result = x * y - variable;
                            Console.WriteLine($"Sonuç: {x} * {y} - {selectablevariable} = " + result);
                            break;
                        case "/-":
                            result = x / y - variable;
                            Console.WriteLine($"Sonuç: {x} / {y} - {selectablevariable} = " + result);
                            break;

                        case "+*"://* değişken işlemleri
                            result = x + y * variable;
                            Console.WriteLine($"Sonuç: {x} + {y} * {selectablevariable} = " + result);
                            break;
                        case "-*":
                            result = x - y * variable;
                            Console.WriteLine($"Sonuç: {x} - {y} * {selectablevariable} = " + result);
                            break;
                        case "**":
                            result = x * y * variable;
                            Console.WriteLine($"Sonuç: {x} * {y} * {selectablevariable} = " + result);
                            break;
                        case "/*":
                            result = x / y * variable;
                            Console.WriteLine($"Sonuç: {x} / {y} * {selectablevariable} = " + result);
                            break;

                        case "+/":// / değişken işlemleri
                            result = x + y / variable;
                            Console.WriteLine($"Sonuç: {x} + {y} / {selectablevariable} = " + result);
                            break;
                        case "-/":
                            result = x - y / variable;
                            Console.WriteLine($"Sonuç: {x} - {y} / {selectablevariable} = " + result);
                            break;
                        case "*/":
                            result = x * y / variable;
                            Console.WriteLine($"Sonuç: {x} * {y} / {selectablevariable} = " + result);
                            break;
                        case "//":
                            result = x / y / variable;
                            Console.WriteLine($"Sonuç: {x} / {y} / {selectablevariable} = " + result);
                            break;

                        default: //geçersiz bir şey yazıldı ise çökmeyi önlüyor
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

            Console.WriteLine();
            Console.WriteLine("Kullandığın için teşekkürler!");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
