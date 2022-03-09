using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class GryazevProgram
    {
        static void Main(string[] args)
        {
            for (int i = 1; i == 1; i++)
            {
                string choice = "";
               
                /// Выбор действия
                for (int f = 1; f == 1; f++)
                {
                    /// Вывод указаний пользователю на экран
                    Console.WriteLine("Создать квадрат(1) или строку чисел(2)?");

                    choice = Console.ReadLine();

                    /// Обработка выбора пользователя
                    switch (choice.Trim())
                    {
                        case ("1"):
                            Console.WriteLine("Введите число больше 1");
                            break;

                        case ("2"):
                            Console.WriteLine("Введите число больше 0");
                            break;

                        default:
                            Console.WriteLine("Ошибка: Ответ введен неправильно. Нужно ввести 1 или 2");
                            f = 0;
                            break;
                    }
                }

                /// Проверка типа вводимых данных
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    /// Проверка значений и вывод строки чисел
                    if (result > 0 && choice.Trim() == "2")
                    {
                        Console.WriteLine(ProjectAssist.GetStringOfNumbers(result));
                    }
                    else if (choice.Trim() == "1")
                        Console.WriteLine("");
                    else
                        Console.WriteLine("Ошибка: Введенное число равно или меньше 0");

                    /// Проверка значений и вывод квадрата из строк
                    if (result > 1 && choice.Trim() == "1")
                    {
                        string[] square = ProjectAssist.GetStringSquare(result);

                        for (int s = 0; s < result; s++)
                        {
                            Console.WriteLine(square[s]);
                        }
                    }
                    else if (choice.Trim() == "2")
                        Console.WriteLine("");
                    else 
                        Console.WriteLine("Ошибка: Введенное число равно или меньше 1");
                }
                else
                    Console.WriteLine("Ошибка: Введено не число");

                /// Выбор выхода или продолжения работы программы
                for (int j = 1; j == 1; j++)
                {
                    Console.WriteLine("Закончить работу?(Y/N)");
                    string answer = Console.ReadLine();
                    
                    /// Обработка ответа
                    switch (answer)
                    {
                        case ("Y"):
                            i = 2;
                            j = 2;
                            break;

                        case ("N"):
                            i = 0;
                            j = 2;
                            break;

                        default:
                            Console.WriteLine("Ошибка: Ответ введен неправильно. Нужно ввести Y или N");
                            j = 0;
                            i = 0;
                            break;
                    }
                }
            }
        }
    }
}
