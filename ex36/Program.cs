/**********************************************************

Задача 36
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

**********************************************************/


int EnterNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int SumOddPosElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = EnterNum("Укажите размер массива: ");
int min = EnterNum("Укажите минимальный элемент массива: ");
int max = EnterNum("Укажите максимальный элемент массива: ");
var myArray = GenerateArray(size, min, max);
PrintArray(myArray);
Console.WriteLine($"Сумма элементов нечётного индекса: {SumOddPosElements(myArray)}");