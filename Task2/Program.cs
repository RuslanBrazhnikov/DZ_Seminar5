// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int element = 8;
int[] arr = new int[element];

void FillArray(int elem, int[] array)
{
    for (int i = 0; i < elem; i++)
    {
        array[i] = new Random().Next(1,9); 
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
        if (i % 2 != 0) result = result + arr[i];
    }
    return result;
}

FillArray(8, arr);
int res = GetMass(result);
PrintArray(8, arr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");