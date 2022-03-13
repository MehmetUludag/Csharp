using System.Collections;
namespace KoleksiyonlarSoru1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            int n = 0;

            Console.WriteLine("Lüften 20 adet pozitif tam sayı giriniz: ");
            for (int i = 0; i < 20; i++)
            {
                try
                {
                    n = Convert.ToUInt16(Console.ReadLine());
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz! " + e.Message);
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Lütfen pozitif bir tam sayı giriniz! " + e.Message);
                }

                AsalMi(n);
                if(AsalMi(n) == true)
                    asal.Add(n);
                else
                    asalDegil.Add(n);
            }

            asalDegil.Sort();
            asal.Sort();
            asalDegil.Reverse();
            asal.Reverse();
            Console.Write("Asal Sayılar: ");
            double a = 0;
            double ad = 0;
            foreach (int item in asal)
            {
                Console.Write(item + " ");
                a += item;
            }

            Console.Write("\nAsal Olmayan Sayılar: ");
            foreach (int item in asalDegil)
            {
                Console.Write(item + " ");
                ad += item;
            }

            a = a / asal.Count;
            ad = ad / asalDegil.Count;
            Console.WriteLine("\nAsal Eleman Sayısı: {0}\nAsal Sayıların Ortalaması: {1}",asal.Count,a);
            Console.WriteLine("Asal Olmayan Eleman Sayısı: {0}\nAsal Olmayan Sayıların Ortalaması: {1}",asalDegil.Count,ad);

        }

        static bool AsalMi(int sayi)
        {  
            int t;
            for ( t = 2; t <= sayi - 1; t++)
            {
                if (sayi % t == 0)
                {
                    return false;
                }
            }

            if (t == sayi)
            {
                return true;
            }
            else   
                return false;
        }

    }
}