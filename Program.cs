using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hotel
    { 
        public string Name { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new List<Hotel>
            {
                new Hotel {Name = "Hotel A", Category = "3*"},
                new Hotel {Name = "Hotel B", Category = "4*"},
                new Hotel {Name = "Hotel C", Category = "3*"},
                new Hotel {Name = "Hotel D", Category = "5*"},
                new Hotel {Name = "Hotel E", Category = "5*"},
                new Hotel {Name = "Hotel F", Category = "3*"},
            };

            var result = CountHotelByCategory(hotels);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadLine();
        }
        
        private static Dictionary<string, int> CountHotelByCategory(List<Hotel> hotels)
        {
            Dictionary<string, int> primer = new Dictionary<string, int>();

            primer.Add("3*", hotels.Select(x => x).Where(x => x.Category == "3*").Count());
            primer.Add("4*", hotels.Select(x => x).Where(x => x.Category == "4*").Count());
            primer.Add("5*", hotels.Select(x => x).Where(x => x.Category == "5*").Count());

            return primer;
        }
    }
}
