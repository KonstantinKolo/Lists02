using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for(int s1 = list.Count - 1;s1 >= 0; s1--)
            {
                if (list[s1] < 0)
                {
                    list.Remove(list[s1]);
                }
            }
            list.Reverse();
            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
