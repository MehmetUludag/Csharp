using System;

namespace MethodTanimlama
{
    
    class Program
    {

        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırVeTopla(a,b); 
            ornek.EkranaYazdir(Convert.ToString(sonuc2));

        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Methodlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        } 

        public int ArttırVeTopla(int deger1, int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 + deger2);
        }
    }
}