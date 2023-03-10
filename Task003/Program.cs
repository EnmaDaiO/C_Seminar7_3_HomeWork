// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
//  элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreatMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols]; // [строчка, столбец]
    for (int i = 0; i < rows; i++) // строчки; rows = matrix.GetLength(0)
    {
        // i,j,m,k - индексы
        for (int j = 0; j < cols; j++)// столбцы; cols = matrix.GetLength(1)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix; // Вернули заполненную табличку
}

void PrintMatrix(int[,] matr) // Печатаем двумерный массив
{
    for (int i = 0; i < matr.GetLength(0); i++) // проход по строчкам
    {
        for (int m = 0; m < matr.GetLength(1); m++) // Проход по столбцам
        {
            Console.Write(matr[i, m] + "\t"); // "\t" = 4 пробела или tab
        }
        Console.WriteLine();
    }
}

// 1. Создать массив
int[,] resultMatrix = CreatMatrix(3, 4, 0, 10);
// 3 строчки и 4 столбца, числа от 0 до 10 включительно

//2. Посмотрим на нашу матрицу
PrintMatrix(resultMatrix);

//РЕШЕНИЕ:
for (int i = 0; i < resultMatrix.GetLength(0);i++)
{
        int sumElementCols = 0;
        for (int m = 0; m < resultMatrix.GetLength(1);m++)
        {
            sumElementCols = sumElementCols + resultMatrix[i,m];
        }    
        double averageCols = sumElementCols / resultMatrix.GetLength(0);
        int colsNumb = i +1 ;
        Console.WriteLine("Среднее арифметического " + colsNumb + " column is " + averageCols);
}

// не учитывается 4-ый столбец - почему?




// Нашел вроде бы работающий код\решение, но не понял почему не учитывается 4-ый столбец 



// for (int i = 0; i < resultMatrix.GetLength(0); i++)
// {

//     int summ = 0;
//     for (int j = 0; j < 3; j++)
//     {
//         summ = summ + resultMatrix[j, i];
//     }
//     double average = summ / 3;
//     int n = i +1 ;
//     Console.WriteLine("Avarage for " + n + " column is " + average);
// }