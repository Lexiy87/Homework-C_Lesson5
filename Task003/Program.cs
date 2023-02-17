// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов 
// массива.

// [3 7 22 2 78] -> 76


double GetNumber(string message)
{
    double number = 0;
    Console.WriteLine(message);
    while (true)
    {

        if (double.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else Console.WriteLine("Вы ввели неверное значение, повторите ввод ");
    }
    return number;
}

double[] InitArray()
{
    double[] result = new double[5];


    for (int i = 0; i < result.Length; i++)
    {
        result[i] = GetNumber("Введите вещественные числа");
    }
    return result;
}

void PrintArray(double[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write($"{result[i]} ");
    }
    System.Console.WriteLine();
}

// Найдите разницу между максимальным и минимальным элементов 
// // массива.
double FindNumber(double[] result)
{
    double max = result[0];
    double min = result[0];
    
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i] > max)
        {
            max = result[i];
        }
        else if (result[i] < min)
        {
            min = result[i];
        }

    }
    double difference = max - min;
    return difference;
}
// double number = GetNumber("Введите вещественные числа");
double[] result = InitArray();
PrintArray(result);
double difference = FindNumber(result);
PrintArray(result);

System.Console.WriteLine("Разницу между максимальным и минимальным элементом " + difference);