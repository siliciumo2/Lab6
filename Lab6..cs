Console.WriteLine("Введите количество строк и столбцов матрицы");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[x, y];
Console.WriteLine("Введите элементы массива");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        massiv[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int min = massiv[0, 0];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
        if ((massiv[i, j] < min) &(massiv[i, j]!=0))
        {
            min = massiv[i, j];
        }
}
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (massiv[i, j] == 0)
        {
            massiv[i, j] = min;
        }
    }
}
Console.WriteLine("Полученный массив =");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.WriteLine(massiv[i, j]);
    }
}
