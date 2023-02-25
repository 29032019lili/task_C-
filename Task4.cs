
int a, b; 
int c;
Console.WriteLine("Введите три числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a);
{
    max = b;
}
    
if (c > max);
{
    max = c;
}
    
Console.WriteLine("max = {0}", max);