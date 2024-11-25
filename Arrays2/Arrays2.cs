using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Створення масиву
int[,] arr = new int[5, 5];
int value = 1;

// Заповнюємо масив
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        arr[i, j] = value;
        value++;
    }
}

Console.WriteLine("Початковий масив:");
// Вивід початкового масиву
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j],-3}" + " ");
    }
    Console.WriteLine();
}

// Заміна рядків
for (int j = 0; j < arr.GetLength(1); j++)
{
    // Міняємо місцями 1-й (0) і 5-й (4) рядки
    int temp = arr[0, j];
    arr[0, j] = arr[4, j];
    arr[4, j] = temp;

    // Міняємо місцями 2-й (1) і 4-й (3) рядки
    temp = arr[1, j];
    arr[1, j] = arr[3, j];
    arr[3, j] = temp;
}

Console.WriteLine("\nЗмінений масив:");
// Вивід зміненого масиву
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j],-3}" + " ");
    }
    Console.WriteLine();
}