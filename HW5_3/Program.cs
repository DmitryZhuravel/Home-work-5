//  Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76
int length = Prompt("Введите длину массива =>  ");
int[] arr = RandArray(length);
PrintArray(arr);
int sum=Max(arr);
int sum2=Min(arr);
int sum3=sum-sum2;
Console.WriteLine($"Разница между максимальным значением {sum} и минимальным {sum2} равна {sum3}");

int Max(int[] arr) 
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max=arr[i];
    }
    return max;
}
int Min(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min=arr[i];
    }
    return min;
}

void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}

int[] RandArray(int length)
{
    int[] answer = new int[length];
    for (int i = 0; i < length; i++)
    {
        answer[i] = new Random().Next(100, 1000);
    }
    return answer;
}

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
