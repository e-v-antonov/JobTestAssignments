using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Enumerable.Range(start: 1, count: 100).ToArray();

            Dictionary<int, List<int>> result1 = LoopImplementation(array);
            Dictionary<int, List<int>> result2 = array.ToDictionary(x => x, i => array.Where(j => j != i && j % i == 0).ToList());

            var elements1 = result1.Select(x => x.Value.Select(y => (x.Key, y))).SelectMany(x => x);
            var elements2 = result2.Select(x => x.Value.Select(y => (x.Key, y))).SelectMany(x => x);

            Console.WriteLine(elements1.SequenceEqual(elements2));
            Console.ReadLine();
        }

        private static Dictionary<int, List<int>> LoopImplementation(int[] array)
        {
            var result = new Dictionary<int, List<int>>();

            foreach (int i in array)
            {
                result.Add(i, new List<int>());

                foreach (int j in array)
                {
                    if (j != i && j % i == 0)
                    {
                        result[i].Add(j);
                    }
                }
            }

            return result;
        }
    }
}
