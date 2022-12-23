Console.Write ("Для решения задачи №13 введите любое число ");
    Int64 number = Convert.ToInt64(Console.ReadLine());
    Console.WriteLine ($"Введеное число: {number}");
    string massive = number.ToString();
    //Console.WriteLine ($"Массив: {massive}");
    int size = massive.Length;
    //Console.WriteLine ($"Размер массива: {size}");
    if (size < 3)
    {
    Console.WriteLine("Введено не трехзначное число ");
    }
    else
    {
      Console.WriteLine($"Третья цифра в введенном числе равна: {massive[2]}");
    }