//Задача 52: В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m,n];

for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write($"{matrix[i, j] + "\t"} ");
    }
    Console.WriteLine();
}

for(int i = 0; i < m; i+= 2)
{
    for(int j = 0; j < n; j+=2)
    {
        matrix[i,j] = matrix[i,j] * matrix[i,j];
       
    }
    Console.WriteLine();
}
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
       
        Console.Write($"{matrix[i, j] + "\t"} ");
    }
    Console.WriteLine();
 }   