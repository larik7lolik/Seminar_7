//Задача 48: Показать двумерный массив размером m×n заполненный целыми числами.
int m = new Random().Next(1,4);
int m = new Random().Next(1,4);
int[,] matrix = new int[m, n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.WriteLine($"{matrix[i, j]} ");
    }
}
