using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> answerList = numbersList.ToList(); ;
            List<int> bombAndStrength = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = bombAndStrength[0];
            int strength = bombAndStrength[1];
            int indexOfBomb = numbersList.IndexOf(bomb);
            int sum = 0;
            if (indexOfBomb - strength > 0)
            {
                for (int s1 = numbersList.IndexOf(bomb) - 1; s1 > numbersList.IndexOf(bomb) - strength - 1; s1--) 
                {
                    answerList.RemoveAt(s1);
                    Console.WriteLine(string.Join(" ", answerList));
                }
            }
            else if(indexOfBomb > 0)
            {
                for (int s12 = indexOfBomb; s12 >= 0; s12--)
                {
                    answerList.RemoveAt(s12);
                }
            }
            //Console.WriteLine(string.Join(" ", answerList));
            if (indexOfBomb + 1 + strength < numbersList.Count - indexOfBomb + 1)
            {
                for (int s2 = answerList.IndexOf(bomb) + strength; s2 > answerList.IndexOf(bomb) ; s2--) 
                {
                    answerList.RemoveAt(s2);
                    Console.WriteLine(string.Join(" ", answerList));
                }
            }
            else
            {
                for (int s21 = answerList.Count - 1; s21 > answerList.IndexOf(bomb); s21--)
                {
                    answerList.RemoveAt(s21);
                }
            }
            //Console.WriteLine(string.Join(" ", answerList));
            answerList.Remove(bomb);
            for (int s3 = 0; s3 < answerList.Count; s3++)
            {
                sum = sum + answerList[s3];
            }
            Console.WriteLine(string.Join(" ", answerList));
            Console.WriteLine(sum);
         }
    }
}
