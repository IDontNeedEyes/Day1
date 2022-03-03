using System;

namespace ClassLibrary1
{
    public class ProjectAssist
    {
        public static string Numbers(int EndNumber)
        {
            string s = "";
            for(int i = 1;i<=EndNumber;i++)
            {
                s += $"{i} ";
            }
            return s;
        }

        public static void Square(int n)
        {
            string string1 = "";
            string string2 = "";
            for (int i = 0; i < n;i++)
            {
                if (i == 0 || i == n - 1)
                {
                    string2 += "* ";
                }
                else string2 += "  ";

                string1 += "* ";
            }
            for (int i = 0;i<n;i++)
            {
                if(i == 0 || i == n-1)
                {
                    Console.WriteLine(string1);
                }
                else Console.WriteLine(string2);
            }
        }
    }


}
