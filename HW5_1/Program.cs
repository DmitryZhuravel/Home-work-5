//  Задача 1: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных и не четных чисел в массиве.
// [345, 897, 568, 234] -> 2
int length = Prompt("Введите длину массива =>  ");
int[] arr = RandArray(length);
PrintArray(arr);
int sum=Even(arr);
int sum2=Odd(arr);
Console.WriteLine($"Количество четных чисел равно {sum}, нечетных {sum2}");
 
int Even(int[] arr)
{

    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sum++;
    }
    return sum;
}

int Odd(int[] arr)
{

    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0) sum++;
    }
    return sum;
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