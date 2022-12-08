// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine ("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
        Console.WriteLine ($"Введите {i+1} число");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
            count +=1;
}
Console.WriteLine($"Введено {count} числа(ел) больше 0");