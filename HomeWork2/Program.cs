using System;

namespace HomeWork2
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz! \nLütfen Çözmek İstediğiniz Soruyu Seçin: ");
            int soru = int.Parse(Console.ReadLine());

            switch (soru)
            {
                case 1:
                    Soru1();
                    break;
                case 2:
                    Soru1();
                    break;
                case 3:
                    Soru1();
                    break;
                default:
                    Console.WriteLine("Lütfen 1-3 arası bir sayı girin!");
                    break;
            }
            
        }

        static async void Soru1()
        {
            List<int> asal = new List<int>();
            List<int> asalDegil = new List<int>();

            /*for(int i = 0; i < 20; i++)
            {
                int x = int.Parse(Console.ReadLine());

            }*/
        }

        static void Soru2()
        {

        }

        static void Soru3()
        {

        }
    }
}