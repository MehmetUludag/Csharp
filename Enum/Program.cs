namespace csharp_enum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);   //index değerine erişme

            int sicaklik = 32;

            if(sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için fazla soğuk bir gün.");
            else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik <= (int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hava çok güzel haydi dışarı çıkalım!");
            else if(sicaklik > (int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Dışarıya çıkmak için fazla sıcak bir gün.");
        }
    }
    enum Gunler
    {
        Pazartesi = 1,      // = 1 ifadesi ile index değerini 1'den başlatmış oluyoruz.
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}