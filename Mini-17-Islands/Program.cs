using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "proogrrrammmingggarrrr".ToCharArray();
            foreach (var item in get_islands(input))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static Dictionary<char,int> get_islands(char[] input)
        {
            var islands = new Dictionary<char,int> { };
            var count = 0;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                    count++;
                else
                    count = 0;
                if (count > 0 && !islands.Keys.Contains(input[i - 1]))
                {
                    islands[input[i - 1]] = i - count;
                }
            }

            return islands;
        }
    }
}
