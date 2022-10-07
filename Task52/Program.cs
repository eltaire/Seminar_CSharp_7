//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = ReadInt("Введите количество строк Вашего массива: ");
int n = ReadInt("Введите количество столбцов Вашего массива: ");
int[,] numbers = new int[m, n];
FillArrayMN(numbers);
PrintArrayMN(numbers);

Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
    double result = 0.0;
    for (int j = 0; j < m; j++)
    {
        result += numbers[j, i];
    }
    result = Math.Round(result / m, 1);
    Console.WriteLine($"столбца №{i+1}:  {result}");
}
void FillArrayMN(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
void PrintArrayMN(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
