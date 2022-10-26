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
        Console.WriteLine("Нет, это не число " + k + "" );

            k = Convert.ToInt32(Console.ReadLine());
    }
}
Console.ReadLine();