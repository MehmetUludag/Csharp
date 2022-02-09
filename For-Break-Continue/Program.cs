using System;

namespace for_break_continue
{

    class Program
    {

        static void Main(string[] args)
        {
            //Girilen sayıdan küçük olan tek sayıları yazdırır.
            Console.Write("Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayi; i++)
            {
                if(i%2 == 1)
                    Console.WriteLine(i);
            }

            // 0 ile 1000 arasındaki tek ve çift sayıları kendi aralarında toplayarak yazdırır.
            int ttoplam = 0, ctoplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i%2 == 1)
                    ttoplam = ttoplam + i;   
                else
                    ctoplam = ctoplam + i;
            }

            Console.WriteLine("Tek Toplam: " + ttoplam);
            Console.WriteLine("Çift Toplam: " + ctoplam);

            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i == 4)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}

