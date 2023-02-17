// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int [] IntArray ()
{
    int[]result = new int [4];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i]=rnd.Next(100,1000);
    }
    return result;
}

void PrintArray (int[] result)
{
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.Write($"{result[i]} ");
    }
    Console.WriteLine();
}

int CheckNumbers (int [] result)
{
    int count=0;
    for (int i = 0; i < result.Length; i++)
    {
        if(result[i]%2==0)
        {
            count++;
        }
    }
return count;
}

int []result = IntArray();
PrintArray(result);
int count = CheckNumbers(result);

Console.Write("Количество четных чисел в массиве " + count);


