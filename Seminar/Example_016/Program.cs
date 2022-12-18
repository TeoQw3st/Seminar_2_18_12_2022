Console.WriteLine("Привет, дорогой юзер, введи, пожалуйста первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И снова дратути, дорогой юзер, введи, пожалуйста второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"А сейчас мы включим магию и проверим является ли число {number2} корнем числа {number1}");
if (number1 == number2*number2)
{
    Console.WriteLine($"Магия свершилась и {number2} является корнем числа {number1}");
}
else
{
    Console.WriteLine($"Магия свершилась и {number2} не является корнем числа {number1}");
}
