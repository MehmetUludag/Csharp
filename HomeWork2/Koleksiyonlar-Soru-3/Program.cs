using System.Text.RegularExpressions;
using System.Collections;
namespace KoleksiyonlarSoru3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList sesliHarfler = new ArrayList();
            string cumle = Console.ReadLine();
            char[] sesli = {'a','e','ı','i','o','ö','u','ü'};
            for (int i = 0; i < cumle.Length; i++)
            {
                if(sesli.Contains(cumle[i]))
                    sesliHarfler.Add(cumle[i]);
            }

            foreach (var item in sesliHarfler)
            {
                Console.Write(item + " ");
            }

        }
    }
}