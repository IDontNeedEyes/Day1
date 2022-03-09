using System;

namespace ClassLibrary1
{
    public class ProjectAssist
    {
        /// <summary>
        /// Создает строку чисел от 1 до N
        /// </summary>
        /// <param name="lastNumber">Число N</param>
        /// <returns>Возвращает строку чисел</returns>
        public static string GetStringOfNumbers(int lastNumber)
        {
            if (lastNumber > 0)
            {
                string result = "";

                for (int i = 1; i <= lastNumber; i++)
                {
                    result += $"{i} ";
                }

                return result;
            }
            else throw new IndexOutOfRangeException("Введенное значение меньше или равно 0");
        }

        /// <summary>
        /// Создает массив строк, которые вместе образуют квадрат, со стороной N
        /// </summary>
        /// <param name="squareSideSize">Размер стороны квадрата</param>
        /// <returns>Массив строк</returns>
        public static string[] GetStringSquare(int squareSideSize)
        {
            if (squareSideSize > 1)
            {
                /// Создание переменных
                string[] result = new string[squareSideSize];
                string string1 = "";
                string string2 = "";

                /// Заполнение шаблонов строк
                for (int i = 0; i < squareSideSize; i++)
                {
                    if (i == 0 || i == squareSideSize - 1)
                    {
                        string2 += "* ";
                    }
                    else 
                        string2 += "  ";

                    string1 += "* ";
                }

                /// Построение квадрата из шаблонов 
                for (int i = 0; i < squareSideSize; i++)
                {
                    if(i == 0 || i == squareSideSize - 1)
                    {
                       result[i] = string1;
                    }
                    else
                        result[i] = string2;
                }

                return result;
            }
            else throw new IndexOutOfRangeException("Введенное значение меньше или равно 1");
        }
    }


}
