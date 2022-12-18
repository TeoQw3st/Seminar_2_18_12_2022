int number = new Random().Next(100, 1000);
Console.WriteLine($"Система сгенерировала случайное число {number}");

int Firstnum = number / 100;
Console.WriteLine($"Первое число равно: {Firstnum}");
int Varnum = (number/10);
int Secondnum = number - Varnum*10;
Console.WriteLine($"Третье число равно: {Secondnum}");
int FinalNum = Firstnum*10 + Secondnum;

Console.WriteLine(FinalNum);
