using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            int op = 0;
            while (op != 4)
            {
                Console.WriteLine("1. Угадай число \n" +
                "2. Таблица умножения \n" +
                "3. Вывод делителей числа \n" +
                "4. Выход из программы");
                Console.Write("Введите номер операции: ");

                op = Convert.ToInt32(Console.ReadLine());
                if (op == 1)
                {
                    Prog1();
                }
                if (op == 2)
                {
                    Prog2();
                }
                if (op == 3)
                {
                    Prog3();
                }
                if (op == 4)
                {
                    Environment.Exit(0);
                }
            }
        }

        static void Prog1()
        {
            Random rand = new Random();
            int i = rand.Next(100);

            Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгодать его за три попытки.");
            Console.WriteLine("Введите число:");
            int k = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (i == k)
                {
                    Console.WriteLine("Да! Компьютер загадал число " + k + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("Нет, это не число " + k + "");

                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }

        static void Prog2()
        {
            Console.WriteLine("\ny/x|   1\t2\t3\t4\t5\t6\t7\t8\t9");
            Console.Write("--------------------------------------------------------------------------");
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "   |  ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        static void Prog3()
        {

            Console.Write("Введите число ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Число {0} делится без остатка на {1}", num, i);
                }

            }
            Console.ReadKey();

        }
    }
}