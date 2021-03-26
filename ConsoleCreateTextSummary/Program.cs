using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCreateTextSummary
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "одол zлол uлдодо оллло wлло лоло олл длодо одлодл олдо дло длоло одо длол лод додо лодо доолло лдоло лдлодло дллодл о лолд";

            Console.WriteLine(CreateTextSummary(text, 10));
            Console.ReadLine();
        }

        public static string CreateTextSummary(string text, int maxLenght = 100)
        {
            string resultText = new string(text.Split(new char[] { ' ' }, maxLenght).Select(x => x[0]).ToArray()); ;

            return resultText;
        }
    }
}
