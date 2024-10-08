internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 3: Вывод элементов массива в обратном порядке
        // Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
        // Используйте рекурсию и не используйте циклы.
        // Пример:
        // ● Вход: {1, 2, 3, 4, 5}
        // ● Выход: 5, 4, 3, 2, 1
        // ● Вход: {10, 20, 30, 40}
        // ● Выход: 40, 30, 20, 10
        int[] ArrayRandomXXXDigits(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }

        void PrintArray(int[] array)
        {
            Console.Write($"[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write($"{array[i]} ,");
                }
                else
                {
                    Console.Write($"{array[i]}");
                }
            }
            Console.Write($"]");
        }

        void InvertedArray(int[] array, int index)
        {
            if (index < 0)
            {
                return;
            }
            Console.Write(array[index] + " ");
            InvertedArray(array, index - 1);
        }

        int[] arr = ArrayRandomXXXDigits(10, 1, 100);
        PrintArray(arr);
        Console.WriteLine();
        InvertedArray(arr, arr.Length - 1);
    }
}