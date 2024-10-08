// // Задача 2: Функция Аккермана
// // Описание: Напишите программу для вычисления функции Аккермана с помощью
// // рекурсии. Даны два неотрицательных числа m и n.
// // Пример:
// // ● Вход: m = 2, n = 3
// // ● Выход: A(m, n) = 29
// // ● Вход: m = 1, n = 4
// // ● Выход: A(m, n) = 7
// функция ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//      вернуть ack(n - 1, ack (n, m - 1))


int Ack(int m, int n)
{
   
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
       
}
Console.WriteLine("Введите первое натуральное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( Ack(num1, num2));