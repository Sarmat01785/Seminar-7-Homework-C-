//                                      Задача 47.
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNum(string message)    // Метод запроса размера строк и столбцов от пользователя.
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
double InputNum2(string message)   // метод запроса минимального и максимального размера вещественных чмсел от пользователя.
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}
double[,] Create2DArray(int cols, int rows) // Метод создания массива вещественных чисел.
{
    return new double[cols, rows];
}
void Fill2DArray(double[,] array, double min, double max) // метод заполнения массива Random.
{
    int dev = 10;  // отклонение.
    Random rnd = new Random();   // Создание экземпляра класса Random.
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round((rnd.NextDouble() - 0.5) * 2 * dev, 2);
}

void Prdouble2DArray(double[,] array)  // Метод печати массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");
        Console.WriteLine();
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
double minValue = InputNum2("Введите минимальное значение диапазона: ");
double maxValue = InputNum2("Введите максимальное значение диапазона: ");

double[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Prdouble2DArray(myArray);
