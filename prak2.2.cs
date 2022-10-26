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