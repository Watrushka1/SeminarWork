/**Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3**/

int[] Arr = new int[5];
int counter = 0;

for (int i = 0; i < Arr.Length; i++)
{
    Console.WriteLine($"Ведите {i} чсло");
    Arr[i] = Convert.ToInt32(Console.ReadLine());
    if (Arr[i] > 0)
    {
        counter++;
    }
}

Console.WriteLine($"[{string.Join(", ", Arr)}]");
Console.WriteLine($" {counter} чисел больше 0");
