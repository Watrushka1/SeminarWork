// Ввод исходного массива строк
Console.WriteLine("Введите элементы массива через запятую:");
string[] inputArray = Console.ReadLine().Split(',');

// Создание нового массива для строк длиной <= 3 символам
string[] newArray = new string[inputArray.Length];
int newIndex = 0;

// Проверка каждой строки и добавление в новый массив, если длина <= 3
for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        newArray[newIndex] = inputArray[i];
        newIndex++;
    }
}

// Вывод нового массива
Console.WriteLine("Новый массив:");
for (int i = 0; i < newIndex; i++)
{
    Console.WriteLine(newArray[i]);
}