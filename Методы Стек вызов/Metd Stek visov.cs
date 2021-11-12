using System;

namespace Массивы_и_строки.cs
{
    class Program
    {
        static string Fibonacci(int per, int vtor, int tr, int fib)
        {
            Console.WriteLine(per);
            if (tr < fib + 1)
                return Fibonacci(vtor, per + vtor, tr + 1, fib);
            return null;
        }
        static string Month(int number)
        {
            string mes = " ";
            if (number == 12 | (number > 0 & number <= 2))
            {
                mes = "Winter";
            }
            else
            {
                if (number >= 3 & number <= 5)
                {
                    mes = "Spring";
                }
                else
                {
                    if (number >= 6 & number <= 8)
                    {
                        mes = "Summer";
                    }
                    else
                    {
                        if (number >= 9 & number <= 11)
                        {
                            mes = "Autumn";
                        }
                        else
                        {
                            mes = "Ошибка: введите число от 1 до 12";
                        }
                    }
                }
            }


            return mes;
        }
        private static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string fullname = firstName + " " + lastName + " " + patronymic;
            return fullname;
        }
        static void Main(string[] args)
        {
            //№1
            string[] f = new string[] { "Крюкова", "Дудник", "Тринкер" };
            string[] n = new string[] { "Ольга", "Андрей", "Борис" };
            string[] o = new string[] { "Петровна", "Романович", "Давидович" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(GetFullName(f[i], n[i], o[i]));
            }
            /* Console.WriteLine("Введите фамилию");
             string fam = Console.ReadLine(); 
             Console.WriteLine("Введите имя");
             string name = Console.ReadLine();
             Console.WriteLine("Введите отчесто");
             string oth = Console.ReadLine();
             Console.WriteLine(GetFullName(fam,name,oth));
            */

            //№2

            Console.WriteLine("\nВведите числа");
            string sum = Console.ReadLine();
            string[] spsum = sum.Split(' ');
            int result = 0;
            for (int i = 0; i < spsum.Length; i++)
            {
                result += Convert.ToInt32(spsum[i]);
            }
            Console.WriteLine(result);

            //№3

            Console.WriteLine("\nВведите номер месяца");
            Console.WriteLine(Month(Convert.ToInt32(Console.ReadLine())));


            //№4
            Console.WriteLine("\nВведити число");
            Console.WriteLine(Fibonacci(0, 1, 1, Convert.ToInt32(Console.ReadLine())));

        }
    }
}