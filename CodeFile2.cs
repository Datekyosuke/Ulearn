﻿public static void Main()
{
    string doubleNumber = "894376.243643";
    double number = double.Parse(doubleNumber, CultureInfo.InvariantCulture); // Вася уверен, что ошибка где-то тут
    Console.WriteLine(number + 1);
}