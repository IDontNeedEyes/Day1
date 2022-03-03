using System;

namespace ClassLibrary1
{
    public class ProjectAssist
    {
        public static string Numbers(int endNumber)
        {
            string result = "";
            for (int i = 1; i <= endNumber; i++)
            {
                result += $"{i} ";
            }
            return result;
        }

        public static void Square(int sideSize)
        {
            string string1 = "";
            string string2 = "";
            for (int i = 0; i < sideSize; i++)
            {
                if (i == 0 || i == sideSize - 1)
                {
                    string2 += "* ";
                }
                else 
                    string2 += "  ";

                string1 += "* ";
            }
            for (int i = 0; i < sideSize; i++)
            {
                if(i == 0 || i == sideSize-1)
                {
                    Console.WriteLine(string1);
                }
                else 
                    Console.WriteLine(string2);
            }
        }
    }


}
