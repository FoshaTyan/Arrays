using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] array1 = { 1, 2, 3, 4, 5 };
int[] array2 = { 4, 5, 6, 7, 8 };
int[] array3 = { 5, 8, 9, 10, 10 };

// Объединение уникальных значений
var union = array1.Union(array2).Union(array3).ToArray();
Console.WriteLine("Об'єднання (унікальні значення): " + string.Join(", ", union));

// Перетин значень
var intersection = array1.Intersect(array2).Intersect(array3).ToArray();
Console.WriteLine("Перетин (спільні значення): " + string.Join(", ", intersection));