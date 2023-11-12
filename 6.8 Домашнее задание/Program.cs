// Задание 1. Случайная матрица

int columns, rows;
Console.WriteLine("Введите кол-во столбцов: ");
columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
rows = int.Parse(Console.ReadLine());

Random random = new Random();
int[,] matrix = new int[columns,rows];
int sum = 0;

for (int i = 0; i < columns; i++)
{
    for (int j = 0; j < rows; j++)
    {
        matrix[i, j] = random.Next(0, 100);
        Console.Write($"{matrix[i, j]} ");
        sum += matrix[i, j];
    }
    Console.WriteLine();
}

Console.WriteLine("Сумма: {0}", sum);

// Задание 2. Сложение матриц