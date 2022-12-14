// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int element = 8;
int[] arr = new int[element];

void FillArray(int elem, int[] array)
{
    for (int i = 0; i < elem; i++)
    {
        array[i] = new Random().Next(100, 1000); 
    }
}

void PrintArray(int elem2, int[] array2)
{
    Console.Write($"array = [ ");
    for (int i = 0; i < elem2; i++)
    {
        Console.Write($"{array2[i]}, ");
    }
    Console.Write($"]");
}
    
int result = 0;

int GetMass(int count)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result = result + 1;
    }
    return result;
}

FillArray(8, arr);
int res = GetMass(result);
PrintArray(8, arr);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {result}");