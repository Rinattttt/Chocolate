

class Program
{

    public static void Main()
    {
        
        // Ввод входных данных
        Console.Write("Введите имеющиеся деньги ($): ");
        int money = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите цену за шоколадку ($): ");
        int price = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество оберток, нужное для получения одной шоколадки: ");
        int wrap = Convert.ToInt32(Console.ReadLine());
        
        // Вывод результата
        Console.WriteLine("Максимальное количество шоколадок: " + Calc(money,price,wrap));
        Console.ReadKey();

    }

    static int Calc(int money, int price, int wrap)
    {


        int max = 0;
        int chocolates = money / price;
        int wrappers = chocolates;
        if (wrappers >= wrap)
        {
            max = (wrappers / wrap) + chocolates;
            return max;
        }
        else { return chocolates; }

    }
}


