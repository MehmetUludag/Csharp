using System;
using System.Collections;

namespace arraylist
{

    public class Program
    {
        
        static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
           /* liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //İçerisindeki verilere nasıl erişiriz?
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
                Console.WriteLine(item);*/

            //AddRange - Birden fazla elemanı ekleme
            Console.WriteLine("**** Add Range *****");
            //string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1,55,9,4,3,5,7};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
                Console.WriteLine(item);
            
            //Sort
            Console.WriteLine("***** Sort *****");
            liste.Sort();           // Runtime hatası verme ihtimali kontrol edilmelidir.
            foreach (var item in liste)
                Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("***** Reverse *****");
            liste.Reverse();
            foreach(var item in liste)
                Console.WriteLine(item);

            //Clear 
            liste.Clear();
            foreach(var item in liste)
                Console.WriteLine(item);
        }
    }
}