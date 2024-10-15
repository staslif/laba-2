using System;

class ChocolateCalculator
{
    static void Main()
    {
        // Запрос данных у пользователя
        Console.WriteLine("Пожалуйста, укажите сумму денег: ");
        int totalFunds = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Какова стоимость одной шоколадки? ");
        int chocolateCost = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сколько оберток нужно для обмена на новую шоколадку? ");
        int wrappersNeeded = Convert.ToInt32(Console.ReadLine());

        // Получение результата
        int totalChocolates = CalculateMaxChocolates(totalFunds, chocolateCost, wrappersNeeded);

        // Вывод результата
        Console.WriteLine($"Вы сможете купить максимально {totalChocolates} шоколадок.");
    }

    // Метод для вычисления максимального количества шоколадок
    static int CalculateMaxChocolates(int funds, int cost, int wrappersExchange)
    {
        int purchasedChocolates = funds / cost;
        int currentWrappers = purchasedChocolates;

        // Обмен оберток на шоколадки
        while (currentWrappers >= wrappersExchange)
        {
            int newChocolates = currentWrappers / wrappersExchange;
            purchasedChocolates += newChocolates;
            currentWrappers = newChocolates + (currentWrappers % wrappersExchange);
        }

        return purchasedChocolates;
    }
}

