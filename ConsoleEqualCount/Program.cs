using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEqualCount
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> enumerable1 = new List<string>
            {
                "jhkcghc",
                "hgjgvj",
                "kgjghg"
            };

            IEnumerable<string> enumerable2 = new List<string>
            {
                "jhkcghc",
                "hgjgvj",
                "kgjghg"
            };
            int resultCount = 0;
            Console.WriteLine($"Количетсво элементов одинаково: {EqualCount(enumerable1, enumerable2, out resultCount)} Количество элементов равно: {resultCount}");
            Console.ReadLine();
        }

        public static bool EqualCount(IEnumerable<string> enumerable1, IEnumerable<string> enumerable2, out int count)
        {
            if (enumerable1.Count() == enumerable2.Count())
            {
                count = enumerable1.Count();
                return true;
            }

            count = 0;
            return false;
        }
    }
}
