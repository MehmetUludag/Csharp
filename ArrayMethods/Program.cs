using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sort
            int[] numArr = {44,25,66,35,95,3,4,55};
            Console.WriteLine("******Sırasız Dizi******");
            foreach (var nums in numArr)
            {
                Console.WriteLine(nums);
            }

            Console.WriteLine("******Sıralı Dizi******");
            Array.Sort(numArr);
            foreach (var nums in numArr)
            {
                Console.WriteLine(nums);
            }


            //Clear
            Console.WriteLine("******Array Clear******");
            Array.Clear(numArr,2,2);
            foreach (var nums in numArr)
                Console.WriteLine(nums);
            
            //Reverse
            Console.WriteLine("******Array Reverse******");
            Array.Reverse(numArr);
            foreach (var nums in numArr)
                Console.WriteLine(nums);
            

            //IndexOf
            Console.WriteLine("******Array IndexOf******");
            Console.WriteLine(Array.IndexOf(numArr,44));
            
            //Resize
            Console.WriteLine("******Array Resize******");
            Array.Resize<int>(ref numArr,9);
            numArr[8] = 14;

            foreach (var nums in numArr)
                Console.WriteLine(nums);


        }
    }
}