class Program
{

    static double Sum = 0;

    static double Func(double x) => (Math.Pow(x, 2) - 1) / (Math.Pow(x, 2) - 4);
    // ОДЗ: Все, кроме 2 и -2 (выколотые точки)
    static bool ODZChecker(double x)
    {
        if (x == 2 || x == -2)
        {
            Console.WriteLine("Выход за ОДЗ!");
            return false;
        }
        return true;
    }

    static void Main()
    {
        double a = 0, b = 0;
        try
        {
            a = double.Parse(Console.ReadLine()!);
            b = double.Parse(Console.ReadLine()!);
        }
        catch (Exception)
        {
            Console.WriteLine("Ввод содержит недопустимые символы/значения");
            Main();
        }
        if (a < b)
        {
            for (double i = a; i < b; i += 0.1)
            {
                i = Math.Round(i, 1);
                Console.WriteLine("При x = " + i);
                Sum += ODZChecker(i) ? Func(i) : 0;
                Console.WriteLine($"Функция: {Func(i)} Сумма: {Sum}");
            }
        }
        else
        {
            Console.WriteLine("Низ цикла больше верха");
            Main();
        }
        Console.ReadKey();
    }

}
