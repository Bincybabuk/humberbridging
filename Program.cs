using System;

namespace humberbridging
{
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                int sum = 0;
                Console.WriteLine("program for adding the string of array");
                Console.WriteLine("insert string");
                string array = Console.ReadLine();
                string[] sumarray = array.Split('+');


                for (int i = 0; i < sumarray.Length; i++)
                {
                    sum += int.Parse(sumarray[i]);




                }
                Console.WriteLine("sum of array{0}", sum);
                Console.WriteLine($"sum of array{sum}");
            }
            catch
                {
                Console.WriteLine("wrong input");
            
            
            
            
            }

        }
    }
}
