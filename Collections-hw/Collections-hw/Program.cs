using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 2330, 112233, 12, 949, 3764, 2942, 523863 };
            int minNum = nums.Min();
            int maxNum = nums.Max();
            int lessThan10000 = (from numb in nums
                                   where numb < 10000
                                   select numb).Max();

            var evenNums = nums.Where((c, i) => i % 2 == 0).ToList();
            var numsInRange10to100 = nums.Where(n => n >= 10 && n <= 100);
            var numsInRange100000to999999 = nums.Where(n => n >= 100000 && n <= 999999);


            Console.WriteLine("The minimum number is {0}.", minNum);
            Console.WriteLine("The maximum number is {0}.", maxNum);
            Console.WriteLine("The maximum number less than 10,000 is {0}", lessThan10000);
            Console.WriteLine("The numbers at even are: {0}.", string.Join(", ", evenNums));



            Console.WriteLine("Numbers between 100000 and 999999:");
            foreach (var num in numsInRange100000to999999)
            {
                Console.WriteLine(num);

            }

            Console.WriteLine("Numbers between 10 and 100:");
            foreach (var num in numsInRange10to100)
            {
                Console.WriteLine(num);

            }



                



            
        }
    }
}
