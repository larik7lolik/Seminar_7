//Задача 54: В матрице чисел найти сумму элементов главной диагонали.
Console.Clear();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int k = int.Parse(Console.ReadLine());
int[,] array = new int[n,k];
Console.WriteLine();
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
int summ = 0;
int size = k;
if (n < k) size = n;
for(int i = 0; i < size; i++)
{
     summ += array[i,i];   
}
 Console.Write($"Сумма элементов главной диагонали равна: {summ}");  