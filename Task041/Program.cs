// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CheckPositiveNumbers()
{
    Console.Write("Введите количество чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int num = 0;
    int result = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) result++;
    }
    Console.WriteLine($"Чисел больше нуля: {result}");
}
CheckPositiveNumbers();
