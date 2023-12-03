using System.Linq.Expressions;

static void gig()
{
    int furst_number = Convert.ToInt32(Console.ReadLine());
    string symvol = Console.ReadLine();
    int second_number = Convert.ToInt32(Console.ReadLine());
    if (symvol == "+")
    {
        Console.WriteLine(furst_number + second_number);
    }
    else if (symvol == "-")
    {
        Console.WriteLine(furst_number - second_number);
    }
    else if (symvol == "*")
    {
        Console.WriteLine(furst_number * second_number);
    }
    else if (symvol == "/")
    {
        if (second_number == 0)
        {
            Console.WriteLine("Ошибка! Нелзя делить на ноль!");
        }
        else
        {
            Console.WriteLine(furst_number / second_number);
        }
    }
}
gig();