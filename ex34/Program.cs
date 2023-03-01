/**************************************************************************

Задача 34
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] —> 2

**************************************************************************/


int EnterNum(string text) // Ввод целых чисел
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int length) // Генерация массива
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(100, 1000); // [100, 999]
    }
    return array;
}

void PrintArray(int[] array) // Вывод массива в консоль
{
    Console.WriteLine($"[" + string.Join(", ", array) + "]");
}

int CountOfEvenNumbers(int[] array) // Счётчик чётных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int size = EnterNum("Укажите размер массива: ");
int[] myArray = GenerateArray(size);
PrintArray(myArray);
Console.WriteLine($"Чётных чисел в массиве: {CountOfEvenNumbers(myArray)}");