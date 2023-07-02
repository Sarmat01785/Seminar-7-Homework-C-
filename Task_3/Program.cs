//                                           Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int InputNum(string message)    // медот запроса от пользователя (сколько в массиве кол-во строк, столбцов. Max и Min значения.)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int cols) //метод создания массива.
{
    return new int[rows, cols];
}
void Fill2DArray(int[,] array, int min, int max) // метод заполнения массива Random.
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(min, max + 1);
}

void Print2DArray(int[,] array) // метод печати.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}
void ArithmeticAverage(int[,] array)  // метод нахождения среднего арифметического.
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            {
                avg = avg + array[i, j];
            }
        }
        Console.Write($"{avg / array.GetLength(0):f2} ");
    }
}
int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int minValue = InputNum("Введите минимальное значение диапазона: ");
int maxValue = InputNum("Введите максимальное значение диапазона: ");

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
Console.WriteLine();
ArithmeticAverage(myArray);



