Console.Write ("Для решения задачи №10 Введите трехзначное число ");
Int64 number2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine ($"Введеное число: {number2}");
string massive2 = number2.ToString();
//Console.WriteLine ($"Массив: {massive2}");
int size2 = massive2.Length;
//Console.WriteLine ($"Размер массива: {size}");
Console.WriteLine($"Третья цифра в введенном числе равна: {massive2[1]}");