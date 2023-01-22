using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastNum = list[list.Count - 1];            
            for (int s1 = 0; s1 <= list.Count; s1++)
            {
                list.Remove(lastNum);
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
