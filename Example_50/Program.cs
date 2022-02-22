// Задача 50: В двумерном массиве n×k заменить четные элементы на противоположные.
/*  Console.Clear();
int[,] matrix = new int[3, 4];
for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 4; j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        if(matrix[i,j] % 2 == 0) matrix[i,j] = matrix[i,j]*(-1);
        Console.Write($"{matrix[i, j]}  ");
    }
    Console.WriteLine();
/* }  */

Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int k = int.Parse(Console.ReadLine());
int[,] array = new int[n,k];
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < k; j++)
    {
        array[i,j] = new Random().Next(0, 10);
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < k; j++)
    {
        if (array[i,j] % 2 == 0) array[i,j] = array[i,j] * -1;
        Console.Write(array[i,j] + " \t");
    }
    Console.WriteLine();
} 