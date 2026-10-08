using System;

namespace Program;

class Stars
{
    static void Main()
    {
        Console.Write("Привіт, юний досліднику! Сьогодні, Ви можете знайти положення зірок на небі!\n");
        int size = Read("Введіть розмір (типово 8): ", 8, min: 1);
        int[] stars = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < size; i++)
            stars[i] = Read($"Зірка [{i}] (нажміть Enter для випадкового): ", rnd.Next(1, 11), min: 1, max: 10);
            Console.WriteLine("\nOriginal: " + string.Join(" ", stars));
        for (int i = 1; i < size; i += 2) stars[i] = 0;
        Console.WriteLine("Modified: " + string.Join(" ", stars));
    }

    static int Read(string message, int def, int min = int.MinValue, int max = int.MaxValue)
    {
        Console.Write(message);
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return def;
            }
            if (int.TryParse(input, out int res) && res >= min && res <= max)
            {
                return res;
            }
            Console.Write("Вибачте досліднику, спробуйте ще раз!: ");
        }
    }
}