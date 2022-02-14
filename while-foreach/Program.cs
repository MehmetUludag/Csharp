using System;

namespace while_foreach
{

    class Program
    {

    
        static void Main(string[] args)
        {

            /* 1'den başlayarak konsola girilen sayıya kadar (sayı dahil) 
            ortalama hesaplayıp konsola yazdıran program */

            Console.Write("Please Enter A Number:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine(toplam/sayi);

            // a'dan z'ye kadar tüm harfleri konsola yazdıran program

            char character = 'a';

            while(character<='z')
            {
                Console.Write(character + " ");
                character++;  
            }
            
            Console.WriteLine();


            // Foreach Döngüsü

            string[] arabalar = {"Ford", "Fiat", "BMW", "Mercedes"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}