using System;

namespace HomeWork
{

    class HomeWork
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Lüften Çözmek İstediğiniz Ödevi Seçiniz(1-4): ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    HomeWork1();
                    break;
                case 2:
                    HomeWork2();
                    break;
                case 3:
                    HomeWork3();
                    break;
                case 4:
                    HomeWork4();
                    break;
                default:
                    Console.WriteLine("Hatalı Değer Girdiniz!");
                    break;
            }
            
        }

        public static void HomeWork1()
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

        public static void HomeWork2()
        {
            Console.Write("Lüften Eleman Sayısını Giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(
            "Lüften Gireceğiniz Sayıların Katı Olup Olmadığını Öğrenmek İstediğiniz Sayıyı Giriniz: ");
            int m = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Eleman: ",i+1);
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in dizi)
            {
                if(m % item == 0)
                    Console.WriteLine("Tam Bölünen Sayı: " + item);
            }

        }     

        public static void HomeWork3()
        {
            Console.Write("Lüften Kelime Sayısını Giriniz: ");
            int n = int.Parse(Console.ReadLine());

            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. Kelime: ",i+1);
                dizi[i] = Console.ReadLine();
            }

            Array.Reverse(dizi);

            foreach (var item in dizi)
            {
               Console.WriteLine(item);
            }

        }
    
        public static void HomeWork4()
        {
            Console.Write("Lüften Bir Cümle Giriniz: ");
            string sentence = Console.ReadLine();
            string[] kelimeler = sentence.Split(" ");
            int kelimeSayisi = kelimeler.Length;
            string birlesim = string.Join("",kelimeler);
            char[] harfler = birlesim.ToCharArray();
            int harfSayisi = harfler.Length;
            Console.WriteLine("Cümledeki Kelime Sayısı: " + kelimeSayisi);
            Console.WriteLine("Cümledeki Harf Sayısı: " + harfSayisi);

        }
    
    }

}