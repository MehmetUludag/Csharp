namespace KoleksiyonlarSoru2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] enBuyuk = new int[3];
            int[] enKucuk = new int[3];
            int[] sayilar = new int[20];
            int n;
            Console.Write("Lütfen 20 adet sayı giriniz: ");

            for (int i = 0; i < 20; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                sayilar[i] = n;
            }

            Array.Sort(sayilar);
            for (int i = 0; i < 3; i++)
            {
                enKucuk[i] = sayilar[i];
                enBuyuk[i] = sayilar[i + 17];
            }

            Array.Reverse(enBuyuk);

            Console.WriteLine(enBuyuk.Average());
            Console.WriteLine(enKucuk.Average());
            Console.WriteLine(enBuyuk.Average() + enKucuk.Average());

        }
    }
}