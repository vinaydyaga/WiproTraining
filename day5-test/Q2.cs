using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Q2
    {
        public void Show(string str)
        {
            string newStr = "";
            foreach(char ch in str)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    newStr += char.ToLower(ch);
                }
            }
            bool isPal=true;
            int left=0, right=newStr.Length-1;
            while (left < right)
            {
                if (newStr[left] != newStr[right])
                {
                    isPal = false;
                    break;
                }
                left++;
                right--;
            }
            Console.WriteLine(isPal);
        }
        static void Main()
        {
            Console.WriteLine("Enter Sentence : ");
            string str=Console.ReadLine();
            Q2 q2 = new Q2();
            q2.Show(str);
        }
    }
}
