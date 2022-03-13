namespace sinif_Kavrami
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Söz Dizimi
            class SinifAdi
            {
                    [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
                    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listesi]);
                    {
                        Metot Komutları
                    }
            }

            Erişim Belirleyiciler
            * Public
            * Private
            * Internal
            * Protected
            */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Uludağ";
            calisan1.No = 188;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Uludağ";
            calisan2.No = 325;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}",No);
            Console.WriteLine("Çalışanın Departmanı: {0}",Departman);

        }
    }
}