Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.Write("Второе число кратно первому");
}
else
{
    Console.Write($"Второе число не кратно первому, остаток равен {number1 % number2}");

}