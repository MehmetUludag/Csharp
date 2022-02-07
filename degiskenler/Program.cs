using System;

namespace degisken
{

    class Program
    {
        private const string Format = "dd/MM/yyyy";

        static void Main(string[] args)
        {

            byte b = 5;         //1 Byte
            sbyte c = 5;        //1 byte

            short s =5;         //2 Byte
            ushort us = 6;      //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //4byte
            Int32 i32 = 4;      //4 byte
            Int64 i64 = 4;      //8 byte

            uint ui = 2;        //4 byte
            long l = 4;         //8 byte
            ulong ul = 4;       //8 byte

            //REEL SAYILAR
            float f =5;         //4 byte
            double d =5;        //8 byte
            decimal de = 5;     //16 byte

            char ch = 'e';      //2 byte
            string str = "Mehmet";  //unlimited

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // string ifadeler

            string str1 = string.Empty;
            str1 = "Mehmet Uludağ";
            string ad = "Mehmet";
            string soyad = "Uludağ";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 5;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10<2;

            // Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;     
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); 

            int int22 = int20 + int.Parse(str20);   // Çıktısı 40

            // datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(datetime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}