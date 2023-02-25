int a;
Console.WriteLine("Введите трехзначное число : ");
a = Convert.ToInt32(Console.ReadLine());
s = ( a % 100) / 10;

Console.WriteLine(s);
