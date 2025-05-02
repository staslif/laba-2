using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Читаем все строки из файла "17.txt" и преобразуем их в массив целых чисел
        int[] integerNumbers = File.ReadAllLines("17.txt").Select(int.Parse).ToArray();

        // Находим минимальное трехзначное число (>=100), которое делится на 7
        int minimumThreeDigitDivisibleBy7 = integerNumbers.Where(num => num >= 100 && num % 7 == 0).DefaultIfEmpty(0).Min();

        // Находим минимальное четырехзначное число (>=1000)
        int minimumFourDigit = integerNumbers.Where(num => num >= 1000).DefaultIfEmpty(0).Min();

        // Вычисляем последнюю цифру минимального четырехзначного числа
        int lastDigitOfMinimumFourDigit = Math.Abs(minimumFourDigit % 10);

        // Инициализируем счетчик подходящих пар
        int validPairCount = 0;

        // Инициализируем переменную для хранения максимальной суммы элементов пар
        int maximumSumOfPairs = int.MinValue;

        // Проходим по всем парам подряд идущих чисел в массиве
        for (int index = 0; index < integerNumbers.Length - 1; index++)
        {
            // Первое число в паре
            int firstNumber = integerNumbers[index];

            // Второе число в паре
            int secondNumber = integerNumbers[index + 1];

            // Проверяем условие: хотя бы одно число в паре меньше minimumThreeDigitDivisibleBy7
            if (firstNumber < minimumThreeDigitDivisibleBy7 || secondNumber < minimumThreeDigitDivisibleBy7)
            {
                // Вычисляем произведение чисел в паре
                int productOfPair = firstNumber * secondNumber;

                // Находим последнюю цифру произведения
                int lastDigitOfProduct = Math.Abs(productOfPair % 10);

                // Проверяем, совпадает ли последняя цифра произведения с последней цифрой minimumFourDigit
                if (lastDigitOfProduct == lastDigitOfMinimumFourDigit)
                {
                    // Увеличиваем счетчик подходящих пар
                    validPairCount++;

                    // Вычисляем сумму чисел в паре
                    int sumOfPair = firstNumber + secondNumber;

                    // Обновляем максимальную сумму, если текущая сумма больше
                    if (sumOfPair > maximumSumOfPairs)
                    {
                        maximumSumOfPairs = sumOfPair;
                    }
                }
            }
        }

        // Выводим результат: количество подходящих пар и максимальную сумму
        Console.WriteLine($"{validPairCount} {maximumSumOfPairs}");
    }
}
