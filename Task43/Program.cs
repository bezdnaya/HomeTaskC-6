// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine ("Введите значения k1, b1, k2 и b2 через пробел или запятую");
string [] str = Console.ReadLine().Split(new char[]{' ',',','.'}, StringSplitOptions.RemoveEmptyEntries);
int [] nums = str.Select(Int32.Parse).ToArray();
if (nums[0] - nums[2] == 0)
{
    if (nums[1]-nums[3] == 0)
        Console.WriteLine("Прямые совпадают и имеют множество решений");
    else
        Console.WriteLine("Прямые параллельны и не имеют точек пересечений");
}
else
{
    double x = (nums[3]-nums[1])/(nums[0]-nums[2]);
    double y = nums[0]*x+nums[1];
    Console.WriteLine($"Координаты точки пересечения прямых {x} и {y}");
}

