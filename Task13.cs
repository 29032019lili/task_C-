Console.Write("Введите любое число: ");
num = Convert.ToInt32(Console.ReadLine());
numDigit = NumberDigit(num);// Пробуем функцию/метод. (прим вероятно подошло бы и для для проверки первой задачи)

if (numDigit <= 2)
    {
        Console.WriteLine("третьей цифры нет");
    }
else
    {
        if (numDigit > 3)
            {
                num = num / Convert.ToInt32(Math.Pow(10, numDigit - 3)); // немного Math
            }
        num = num % 10;
        Console.WriteLine($"Третья цифра введённого числа: {num}");
    }
break;