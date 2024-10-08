// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

// public static void PrintRange(int M, int N)
// {
// if (M > N) return; // Базовый случай: если M больше N,
// прекращаем рекурсию
// Console.Write(M);
// if (M < N) Console.Write(", ");
// PrintRange(M + 1, N);



void AllNaturalNumbersInTheRange(int num1, int num2) 
{
    if( num1>num2)
    {
        return;
    } 
    Console.Write(num1);

    if( num1<num2)
    {
        Console.Write(", ");
    } 
    AllNaturalNumbersInTheRange(num1 +1, num2);
}
Console.WriteLine("Введите первое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
AllNaturalNumbersInTheRange(M, N);