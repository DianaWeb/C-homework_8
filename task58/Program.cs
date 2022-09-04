/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */
System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix1 = GetMatrix1(m, n, 1, 9);
PrintMatrix(ourMatrix1);
System.Console.WriteLine();
int[,] ourMatrix2 = GetMatrix2(m, n, 1, 9);
PrintMatrix(ourMatrix2);
System.Console.WriteLine();
MultiplicationTwoMatrices(ourMatrix1, ourMatrix2, m, n);

void MultiplicationTwoMatrices(int[,] matrix1, int[,] matrix2, int rowsCount, int columnsCount)
{
	int[,] resultMatrix = new int[rowsCount, columnsCount];
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
		}
	}
	for (int i = 0; i < resultMatrix.GetLength(0); i++)
	{
		for (int j = 0; j < resultMatrix.GetLength(1); j++)
		{
			System.Console.Write(resultMatrix[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}

int[,] GetMatrix1(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
	Random rund = new Random();
	int[,] matrix = new int[rowsCount, columnsCount];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rund.Next(leftRange, rightRange + 1);
		}
	}
	return matrix;
}

int[,] GetMatrix2(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
	Random rund = new Random();
	int[,] matrix = new int[rowsCount, columnsCount];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rund.Next(leftRange, rightRange + 1);
		}
	}
	return matrix;
}


void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write(matrix[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}