// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет



int[,] CreatMatrixFoundElement(int rows, int cols, int minValue, int maxValue)
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
int[,] resultMatrix = CreatMatrixFoundElement(3,4,0,10);
// 3 строчки и 4 столбца, числа от 0 до 10 включительно
PrintMatrix(resultMatrix);

System.Console.WriteLine("Введите номер столбца ");
int countCols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер строки ");
int countRows = Convert.ToInt32(Console.ReadLine());
int countElement = 0;
for (int i = 0; i < resultMatrix.GetLength(0); i++) // строчки; rows = matrix.GetLength(0)
{
    // i,j,m,k - индексы
    for (int j = 0; j < resultMatrix.GetLength(1); j++) // столбцы; cols = matrix.GetLength(1)
    {
        if( countCols >= 0 && countCols <= resultMatrix.GetLength(1) && countRows >= 0 && countRows <= resultMatrix.GetLength(0))
        {
            countElement = resultMatrix[countRows, countCols];
        }
        else
        {
            System.Console.WriteLine("Такого числа нет в массиве");
            break;
        }
    }
}
System.Console.WriteLine(countElement);








































// //метод создания матрицы c назначением значений матрицы через консоль

// int[,] CreatMatrix(int rows, int cols) // заполнение матрицы значениями
// {
//     int[,] matrix = new int[rows, cols];// строчка и столбец
//     int count = 0;
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < cols; j++)
//         {
//             System.Console.WriteLine($"Введите {count} значение с индексом столбца{cols} и строчки {rows}  ");
//             matrix[i,j] = Convert.ToInt32(Console.ReadLine());
//             count++;
//         }
//     }
//     return matrix;

// }

// void PrintMatrix(int[,] matr) // метод вывода матрицы в консоль
// {
//     for(int i = 0; i < matr.GetLength(0); i ++) //проход по столбцам GetLength(0) 
//     {
//         for(int j = 0; j < matr.GetLength(0); j ++) //проход по строчкам GetLength(1)
//         {
//             System.Console.WriteLine(matr[i,j] + "\t" );
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] resultMatrix = CreatMatrix(3,4);
// // 3 строчки и 4 столбца, числа от 0 до 10 включительно

// //вызов метода вывода матрица в консоль 
// PrintMatrix(resultMatrix);
