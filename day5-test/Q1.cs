using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Q1
    {
        public void show(string s)
        {
            char[] arr = s.ToCharArray();
            
            for(int i=0;i<arr.Length; i++)
            {
                int c = 0;
                for (int j = 0; j <arr.Length; j++)
                {
                    if (i!=j&&arr[i] == arr[j])
                    {
                        c++;
                        //break;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("first Non-repeating letter : "+arr[i]);
                    return;
                }

            }
            Console.WriteLine("$");
        }
 static void Main()
        {
            Console.WriteLine("Enter Word : ");
            string s=Console.ReadLine();
            Q1 q1 = new Q1();
            q1 .show(s);

        }
    }
}
