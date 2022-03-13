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

            Calisan calisan1 = new Calisan("Ayşe","Uludağ",188,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Uludağ";
            calisan2.No = 325;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();
            Calisan calisan3 = new Calisan("Mehmet","Uludağ");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}",Ad);
            Console.WriteLine("Çalışanın Soyadı: {0}",Soyad);
            Console.WriteLine("Çalışanın Numarası: {0}",No);
            Console.WriteLine("Çalışanın Departmanı: {0}",Departman);

        }
    }
}