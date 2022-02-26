using System;

namespace HomeWork
{

    class HomeWork1
    {
        
        static void Main(string[] args)
        {
            Console.Write("Lüften Pozitif Bir Sayı Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
               dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in dizi)
            {
                if(item % 2 == 0)
                    Console.WriteLine("Girdiğiniz Çift Sayı: " + item);
            }
            
        }
    }
}