Console.WriteLine("\t\t\t\t\tЗадание: 'циклы' на оценку 3");

Console.WriteLine("Выберите вариант: 1-Формулы; 2-Циклы.");
Console.Write("Номер варианта: ");
int variant;
variant = Convert.ToInt32(Console.ReadLine());
if (variant == 1)
{
    Console.WriteLine("\n\t\t\t\t\tФормулы.");
    Console.WriteLine("\nГеометрическая прогрессия");
    Console.Write("Введите первый член: ");
    double firstMemb = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите знаменатель прогрессии: ");
    double denominator = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите номер последнего члена: ");
    double lastMemb = Convert.ToDouble(Console.ReadLine());

    double sum = firstMemb * ((Math.Pow(denominator, lastMemb)) - 1) / (denominator - 1);
    Console.WriteLine($"\t\nСумма геометрической прогрессии = {sum}");

    Console.WriteLine("\n\t\t\t\t\tАрифметическая прогрессия");
    Console.Write("Введите первый член: ");
    double firstMemb3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите разность: ");
    double difference = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите номер последнего члена: ");
    double num = Convert.ToDouble(Console.ReadLine());

    double sum2 = (firstMemb3 + difference) * num;

    Console.WriteLine($"\t\nСумма арифметической = {sum2}");
}

if (variant == 2)

{
    Console.WriteLine("\n\t\t\t\t\tциклы");
    Console.WriteLine("\n\t\t\t\t\tГеом прогрессия"); 
    Console.Write("Введите первый член: ");
    double firstMemb2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите знаменатель прогрессии: ");
    double denominator2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите номер последнего члена: ");
    double lastMemb2 = Convert.ToDouble(Console.ReadLine());
    double reshen = firstMemb2;
    for (double i = 0; i < (lastMemb2 - 1); i++)
    {
        firstMemb2 = firstMemb2 * denominator2;
        reshen = reshen + firstMemb2;

    }
    Console.WriteLine($"\t\nСумма геометрической прогрессии = {reshen}");

    Console.WriteLine("\n\t\t\t\t\tАриф прогрессия");
    Console.Write("Введите первый член: ");
    double firstMemb4 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите разность: ");
    double difference2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число элементов: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double lastnumber = firstMemb4;
    double sum = firstMemb4;


    for (double i = 0; i < (num2 - 1); i++)
    {
        lastnumber = lastnumber + difference2;
        sum = sum + lastnumber;

    }
    Console.WriteLine($"\t\nСумма арифметической прогрессии = {sum}");
}
if (variant != 1 && variant != 2)
{
    Console.WriteLine("Такого варианта нет!");
}

Console.WriteLine("Введите ENTER для продолжения...");
Console.ReadLine();
Console.Clear();
Console.WriteLine("\n\t\t\t\t\tЗадание на оценку 4");

Console.WriteLine("\n\t\t\t\t\tБинарный поиск");
Console.Write("Введите минимальное значение диапазаона: ");
int g;
g = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона: ");
int p;
p = Convert.ToInt32(Console.ReadLine());
int[] massiv = Enumerable.Range(g, p).ToArray();
double low = 0;
double high = massiv.Length - 1;
double input = 0;
int centr = 0;
Console.WriteLine($"Введите число от {g} до {p}");
input = Convert.ToDouble(Console.ReadLine());


while (massiv[centr] != input)
{
    centr = Convert.ToInt32(low + high / 2);

    if (input < massiv[centr])
    {
        high = centr - 1;
    }
    else if (input > massiv[centr])
    {
        low = centr + 1;
    }

    Console.WriteLine($"Число - {input} Позиция в массиве - {centr}");
}

Console.WriteLine("Для завершения нажмите ENTER.");
Console.ReadLine();
Console.Clear();