Console.WriteLine("Задание 1.");
Console.Write("Введите число: ");
double a = Convert.ToDouble(Console.ReadLine());
if (a >= 0)
{
    Console.WriteLine(a + 5);
}
else
{
    Console.WriteLine(a - 5);
}

Console.WriteLine("Задание 2.");
Console.WriteLine("Введите три числа: ");
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double d = Convert.ToDouble(Console.ReadLine());
if (b > c && b > d)
    Console.WriteLine(b + " - наибольшее число");
else if (c > d && c > b)
    Console.WriteLine(c + " - наибольшее число");
else
    Console.WriteLine(d + " - наибольшее число");

Console.WriteLine("Задание 3.");
Console.WriteLine("Введите три числа: ");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
double num3 = Convert.ToDouble(Console.ReadLine());
double k = 0;
if (num1 >= 0) 
    k += num1;
if (num2 >= 0)
    k += num2;
if (num3 >= 0)
    k += num3;
Console.WriteLine("Вывод: " + k);

Console.WriteLine("Задание 4.");
Console.Write("Введите число: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x > 10) 
{
    x = Math.Pow(x, 2);
    Console.WriteLine("результат: " + x);
}
else
    Console.WriteLine("неподходящее число!");

Console.WriteLine("Задание 5.");
Console.Write("Введите число дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    switch (number)
    {
        case 1:
            Console.WriteLine("понедельник");
            break;
        case 2:
            Console.WriteLine("вторник");
            break;
        case 3:
            Console.WriteLine("среда");
            break;
        case 4:
            Console.WriteLine("четверг");
            break;
        case 5:
            Console.WriteLine("пятница");
            break;
        case 6:
            Console.WriteLine("суббота");
            break;
        case 7:
            Console.WriteLine("воскресенье");
            break;
    }
}
else
    Console.WriteLine("число за пределом диапозона");
Console.ReadKey();