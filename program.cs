using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence : ");
            string str = Console.ReadLine();
            string[] words = str.Split(' ');
            int count = 0;
            foreach (string word in words)
            {
                char[] arr= word.ToCharArray();
                Array.Reverse(arr);
                string reversed =  new string(arr);
                if (word==reversed)
                {
                    count++;
                }
            }
            Console.WriteLine($"no. of palindromes : {count}");
        }
    }
}
