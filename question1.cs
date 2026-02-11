using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Question1
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentence : ");
            string str = Console.ReadLine();
            string[] words=str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if(i%2==1)
                {
                    char[] arr=words[i].ToCharArray();
                    Array.Reverse(arr);
                    words[i]=new string(arr);
                }
            }
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
