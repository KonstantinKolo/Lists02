using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string raw = Console.ReadLine();
            raw = raw.Replace(" ", "");
            List<string> list = new List<string>();
            string helper = "";
            int count = 0;
            List<string> answerList = new List<string>();
            string answer;
            foreach(char replace in raw)
            {
                helper = helper + replace;
                if(replace == '|')
                {
                    list.Add(helper);
                    helper = "";
                    count++;
                }
                if (raw[raw.Length - 1] == replace && helper != "|")
                {
                    list.Add(helper);
                    count++;
                }
            }
            for (int s1 = 0; s1 < count; s1++) 
            {
                answer = string.Join("", list[s1]);
                answer = answer.Replace("|", "");                
                answerList.Add(answer);
            }
            string final = "";
            for (int s2 = 0; s2 < answerList.Count; s2++)
            {
                final = final + answerList[answerList.Count-s2-1];
            }
            List<char> chars = new List<char>();
            chars.AddRange(final);
            Console.WriteLine(String.Join(" ", chars));
        }
    }
}
