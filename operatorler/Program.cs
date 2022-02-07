using System;

namespace operatorler
{
    class Program
    {

        static void Main(string[] args)
        {

            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isComleted = false;

            if(isSuccess && isComleted)
                Console.WriteLine("Perfect!");
            
            if(isSuccess || isComleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isComleted)
                Console.WriteLine("Fine!");

            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler
            // /, *, +, -

            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi*sayi2;
            Console.WriteLine(sonuc1);
            sayi += 1;
            Console.WriteLine(sayi);

            // % : mod alır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}