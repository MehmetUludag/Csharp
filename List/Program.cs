using System.Net;
using System;
using System.Collections.Generic;

namespace generic_list
{

    public class Program
    {
        
        static void Main(string[] args)
        {

            //List<T> class
            //System.Collections.Generic
            //T-> obect türündedir

            List<int>sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string>renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //ForEach ve List.ForEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            //İndex sayısına göre çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            //Liste içerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste içerisinde bulundu!");

            
            //Eleman ile indexe erişme
            renkListesi.BinarySearch("Sarı");

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Uludağ";
            kullanıcı1.Age = 56;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Kadir";
            kullanıcı2.Soyisim = "Uludağ";
            kullanıcı2.Age = 57;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Age = 16
            });

            foreach (Kullanıcılar kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Age);
            }

            yeniListe.Clear();

        }
    }

    public class Kullanıcılar
    {
        private string isim;

        private string soyisim;

        private int age;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Age { get => age; set => age = value; }
    }

}