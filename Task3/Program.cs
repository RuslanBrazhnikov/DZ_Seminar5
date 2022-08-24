// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] arr = new double[8];
double max = 0;
double min = 9999;



void FillArray(double elem, double[] array)
{
    for (int i = 0; i < elem; i++)
    {
        array[i] = new Random().Next(10, 90) / 10.0;
    }
}

double GetMaxMin()
{
    for (int i = 0; i < arr.Length; i++) {

        if (arr[i] > max) {
            max = arr[i];
        } 
        if (arr[i] < min)  {
            min = arr[i];
        }
    }

    double res = max - min;

    return res;
}

void PrintArray(double elem2, double[] array2)
{
    Console.Write($"array = [ ");
    for (int i = 0; i < elem2; i++)
    {
        Console.Write($"{array2[i]}, ");
    }
    Console.Write($"]");
}

FillArray(8, arr);
PrintArray(8, arr);
double result = Math.Round(GetMaxMin(), 2);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");