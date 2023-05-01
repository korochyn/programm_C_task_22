//Урок 7. Двумерные массивы
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


//Ввод чисел с экрана
int Promt(string message)
{
    Console.Write(message);
    string ReadInput = Console.ReadLine()!;
    int result = int.Parse(ReadInput);
    return result;
}

//Создание массива 
double[,] GenerateArray(int row1, int colmn1, int maxValue, int minValue)
{
    double[,] array = new double[row1, colmn1];
    Random random = new Random();
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < colmn1; j++)
        {
            array[i, j] = Math.Round(random.Next(minValue, maxValue) + random.NextDouble(), 1);
        }
    }
    return array;
}

// Метод вывода массива
void PrintArray(double[,] array)
{
    int length_0 = array.GetLength(0);
    int length_1 = array.GetLength(1);
    //Console.Write("[");
    for (int i = 0; i < length_0; i++)
    {
        for (int j = 0; j < length_1; j++)
        { Console.Write($"{array[i, j]}  "); };
        Console.WriteLine();
    }

    //Console.WriteLine("]");
}



Lable1:
int row = Promt("Введите количество строк  :");
int colmn = Promt("Введите количество столбцов  :");
int max = Promt("Введите максимальное значение для массива  :");
int min = Promt("Введите минимальное значение для массива  :");
if (min > max) { Console.WriteLine("Минимум не должен быть больше максимума"); goto Lable1; }
else { Console.WriteLine("Данные введены корректно. Массив получен такой:"); }
double[,] array = GenerateArray(row, colmn, max, min);
PrintArray(array);



