Console.Clear();

Console.Write("Add numberA:");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Add numberB:");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
   Console.WriteLine($"Наибольшее число из чисел: {numberA} и {numberB}, число: {numberA}");
}
else 
{
    Console.WriteLine($"Наибольшее число из чисел: {numberA} и {numberB}, число: {numberB}");
}