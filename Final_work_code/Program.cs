using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк
        Console.Write("Input elements of the array with spacebar: ");
        string[] inputArray = Console.ReadLine().Split(' ');

        // Инициализация массива результатов
        string[] resultArray = FilterStrings(inputArray);

        // Вывод массива результатов
        Console.WriteLine("Result:");
        foreach (string str in resultArray)
        {
            Console.Write(str + " ");
        }
    }

    static string[] FilterStrings(string[] input)
    {
        int count = 0;

        // Подсчет количества строк, удовлетворяющих условию
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                count++;
            }
        }

        // Инициализация массива результатов
        string[] result = new string[count];

        // Заполнение массива результатов
        int index = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                result[index] = input[i];
                index++;
            }
        }

        return result;
    }
}