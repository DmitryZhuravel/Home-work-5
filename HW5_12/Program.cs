// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
int length = Prompt("Введите длину массива =>  ");
double [] arr = RandArray(length);
PrintArray(arr);
double sum=Max(arr);
double sum2=Min(arr);
double sum3=sum-sum2;
Console.WriteLine($"Разница между максимальным значением {sum} и минимальным {sum2} равна {sum3}");

double Max (double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max=arr[i];
    }
    return max;
}

double Min (double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min=arr[i];
    }
    return min;
}

double[] RandArray(int lenght)
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        Random rnd = new Random();                   
        answer[i] = -100 + rnd.NextDouble() * 201;
    }
    return answer;
}                                                           

void PrintArray(double[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ", ");

    }
    Console.Write(collect[collect.Length - 1] + "]");
    Console.WriteLine();
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

