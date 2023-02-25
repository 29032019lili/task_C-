
int a, b, с;
Console.WriteLine("Введите три числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
с = Convert.ToInt32(Console.ReadLine());
max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine(max);