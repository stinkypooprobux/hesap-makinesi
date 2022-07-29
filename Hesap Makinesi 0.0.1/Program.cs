using System;

namespace Hesap_Makinesi_0._0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double x = 0;
            double y = 0;
            int operation = 0;

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Ultra Epik Hesap Makinesi v0.0.1");
            Console.WriteLine("----------------------------------------------------");

            try
            {
                Console.WriteLine("İlk numarayı yaz!");
                x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İkinci numarayı yaz!");
                y = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İşlemi yaz! (1 = Toplama, 2 = Çıkarma, 3 = Çarpma, 4 = Bölme, 5 = Yüzdelik, 6 = Bölme Kalanı)");
                operation = Convert.ToInt32(Console.ReadLine());
                while (operation > 6)
                {
                    Console.WriteLine("İşlemi yaz! (1 = Toplama, 2 = Çıkarma, 3 = Çarpma, 4 = Bölme, 5 = Yüzdelik, 6 = Bölme Kalanı)");
                    operation = Convert.ToInt32(Console.ReadLine());
                }
                while (operation < 1)
                {
                    Console.WriteLine("İşlemi yaz! (1 = Toplama, 2 = Çıkarma, 3 = Çarpma, 4 = Bölme, 5 = Yüzdelik, 6 = Bölme Kalanı)");
                    operation = Convert.ToInt32(Console.ReadLine());
                }
            }

            catch (FormatException e)
            {
                Console.WriteLine("(!!!!UYARI!!!!) Lütfen sayıları doğru düzgün yaz!!!!!!!!");
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("(!!!!UYARI!!!!) Sıfırı bölemezsin!!!!!!!!");
            }

            catch (ApplicationException e)
            {
                Console.WriteLine("(!!!!UYARI!!!!) Uygulama hatası!!!!!!!!");
            }

            if (operation == 1)
            {
                result = x + y;
            };
            if (operation == 2)
            {
                result = x - y;
            };
            if (operation == 3)
            {
                result = x * y;
            };
            if (operation == 4)
            {
                result = x / y;
            };
            if (operation == 5)
            {
                result = x * y / 100;
            };
            if (operation == 6)
            {
                result = x % y;
            };

            Console.WriteLine("Sonuç: " + result);
        }
    }
}
