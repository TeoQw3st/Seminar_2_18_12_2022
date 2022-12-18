Console.WriteLine("Привет, дорогой юзер, введи, пожалуйста первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("И снова дратути, дорогой юзер, введи, пожалуйста второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"А сейчас мы включим магию и проверим является ли число {number2} корнем числа {number1}");
if (number1 == number2*number2)
{
    Console.WriteLine($"Магия свершилась и второе число: {number2} является корнем первого числа: {number1}");
}
else if (number2 == number1*number1)
{
    Console.WriteLine($"Магия свершилась и первое число: {number1} является корнем второго числа: {number2}");
}
else
{
    Console.WriteLine($"Магия свершилась и ни одно число не является корнем другого числа");
}
