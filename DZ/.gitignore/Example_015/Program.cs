Console.Write ("Для решения задачи №15 введите число от 1-го до 7-ми ");
    int number3 = Convert.ToInt32(Console.ReadLine());
    string day = "День";
    if (number3 == 1) day = "Понедельник";
    if (number3 == 2) day = "Вторник";
    if (number3 == 3) day = "Среда";
    if (number3 == 4) day = "Четверг";
    if (number3 == 5) day = "Пятница";
    if (number3 == 6) day = "Суббота";
    if (number3 == 7) day = "Воскресенье";
       
   
    if (number3 > 7){
      Console.WriteLine("Вы ввели число больше 7");
    }
    else if (number3 >5 & number3 < 8)
    {
      Console.WriteLine($"Это {day} и это выходной!");
    }
    else
    Console.WriteLine($"Это {day} и это не выходной!");