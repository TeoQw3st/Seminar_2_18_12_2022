// See https://aka.ms/new-console-template for more information
Console.WriteLine("Привет, дорогой юзер, введи, пожалуйста число, а я проверю кратно ли оно 7 и 23 одновременно");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 7 == 0)& (number % 23 ==0))
{
    Console.WriteLine($"Число {number} кратно и 7 и 23 одновременно");
}
else
{
    Console.WriteLine($"Число {number} не кратно и 7 и 23 одновременно");
}