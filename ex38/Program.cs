/***************************************************

Задача 38
Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

***************************************************/


int EnterIntNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double EnterDoubleNum(string text)
{
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double[] GenerateArray(int length, double leftRange, double rightRange)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() * (rightRange - leftRange) + leftRange, rand.Next(0, 3));
    } // NextDouble() [0.0, 1.0) | при округлении до целого числа (Math.Round(num, 0)) [0.0, 1.0]
    
    return array;
}
void PrintArray(double[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }

    return max;
}

double MinNumber(double[] array)
{
    double min = array[0];
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return min;
}

int size = EnterIntNum("Укажите размер массива: ");
double min = EnterDoubleNum("Укажите минимальный элемент массива: ");
double max = EnterDoubleNum("Укажите максимальный элемент массива: ");

double[] myArray = GenerateArray(size, min, max);
PrintArray(myArray);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(MaxNumber(myArray) - MinNumber(myArray), 2)}"); // при 0,95 - 0.05 выдал 0,8999999999999