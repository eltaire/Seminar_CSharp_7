int m = ReadInt("Введите количество строк Вашего массива: ");
int n = ReadInt("Введите количество столбцов Вашего массива: ");
double[,] mn = new double[m, n];
FillArrayMN(mn);
PrintArrayMN(mn);
void FillArrayMN(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}
void PrintArrayMN(double[,] array)
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