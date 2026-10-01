
Console.Write("Введите целое число а: ");
int a = int.Parse(Console.ReadLine());


Console.Write("Введите целое число b: ");
int b = int.Parse(Console.ReadLine());

int current = a;

while(true)
{
    int temp = current;
    int sum = 0;

    while (temp != 0)
    {
        sum += temp % 10;
        temp /= 10;
    }


    if (sum == b)
    {
        Console.WriteLine($"Ответ: {current}");
        break;
    }

    current += b;
}