using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаване на число, с което ще започва опашката
            Console.Write("Enter a start number: ");
            int startNumber = int.Parse(Console.ReadLine());

            // Задаване на числото което ще се търси в опашката
            Console.Write("Enter a number you are looking for: ");
            int findNumber = int.Parse(Console.ReadLine());

            // Деклариране на променлива, в която се записва позицията на търсеното число
            string indexPosition = "";

            // Създаване на опашката
            Queue<int> queue = new Queue<int>();

            // Добавяне на началното число в опашката
            queue.Enqueue(startNumber);

            Console.Write("S = ");

            for (int i = 0; i < 300; i++)
            {
                // Вземане на първия елемент от опашката
                int currentNumber = queue.Dequeue();

                // Разпечатване на елемента в конзолата
                Console.Write($"{currentNumber} ");

                // Проверка дали текущото число е това което търсим
                if (currentNumber == findNumber)
                {
                    // Ако да, следното съобщение ще бъде записано в променливата "indexPosition"
                    indexPosition = $"{Environment.NewLine}Index = {i}";
                    break;
                }

                // Формула за добавяне на числа в редицата
                queue.Enqueue(currentNumber + 1);
                queue.Enqueue(currentNumber * 2);
            }

            // Проверка дали числото е намерено в редицата
            if (string.IsNullOrEmpty(indexPosition))
            {
                // Ако не е, следното съобщение ще бъде записано в променливата "indexPosition"
                indexPosition = $"{Environment.NewLine}" +
                    $"The number you are looking for is not contained in the sequence";
            }

            // Печатане позицията на търсеноато число в редицата
            Console.WriteLine(indexPosition);
        }

    }
}

