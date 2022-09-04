/* Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0, 0, 1)

45(1, 0, 0) 53(1, 0, 1) */
/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8 */
int[,,] ourMatrix = GetMatrix(2, 2, 2, 10, 100);
PrintMatrix(ourMatrix);

int[,,] GetMatrix(int rowsCount, int columnsCount, int widthCount, int leftRange, int rightRange)
{
	Random rund = new Random();
	int[,,] matrix = new int[rowsCount, columnsCount, widthCount];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				matrix[i, j, k] = rund.Next(leftRange, rightRange);
			}
		}
	}
	return matrix;
}

void PrintMatrix(int[,,] matrix)
{
	int[] repeats = new int[100];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				repeats[matrix[i, j, k]]++;
			}
		}
	}
	for (int i = 0; i < repeats.Length; i++)
	{
		if (repeats[i] > 1)
		{
			System.Console.WriteLine($"Есть повторяющтеся двузначные числа :{i} встречается {repeats[i]} раз. Повторите еще раз.");
		}
	}

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
			}
		}
		System.Console.WriteLine();
	}
}