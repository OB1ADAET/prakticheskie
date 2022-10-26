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
