// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1) GetLent
        {
            matrix[i, j] = new Random().NextDouble();
        }
    }
    return matrix; // Возвращение заполненной таблицы
}

void PrintMatrix(double[,] matr) // выводим массив в консоль
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам и считывание элемента
    {
        for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам и считывание элемента
        {
            Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
        }
        Console.WriteLine();
    }
}

//1. Создать массив
double[,] resultMatrix = GetMatrix(3,4);
// 3 строчки и 4 столбца, числа от 0 до 10 включительно

// 2. Посмотрим на нашу матрицу
PrintMatrix(resultMatrix);