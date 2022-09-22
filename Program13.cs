Console.WriteLine("Введите число.");
int input = Convert.ToInt32(Console.ReadLine());
    if (input>99)
        Console.WriteLine("Третья цифра "+input.ToString()+" = "+input.ToString()[2]);
    else if (input<100)
        Console.WriteLine("Третьей цифры нет");
