int a;
Console.WriteLine("Введите число : ");
a = Convert.ToInt32(Console.ReadLine());

if (a % 2==1)
{
    Console.WriteLine("нет");        
}
else
{
    Console.WriteLine("да");
}
   
Console.ReadLine();