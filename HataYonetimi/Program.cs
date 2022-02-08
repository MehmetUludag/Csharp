using System;

namespace hata_yonetimi
{

    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı:" +sayi);
            }

            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }

            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }


            try
            {
                int a = int.Parse(null);
            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz!");
                Console.WriteLine(ex);
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil!");
                Console.WriteLine(ex);
            }

            catch(OverflowException ex)
            {
                Console.WriteLine("Çok Küçük ya da Çok Büyük Değer Girdiniz!");
                Console.WriteLine(ex);
            }

        }
    }
}