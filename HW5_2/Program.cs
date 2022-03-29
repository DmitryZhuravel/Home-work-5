//  Задача 2: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (сумму чисел нечетных индексов).
// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0
int length = Prompt("Введите длину массива =>  ");
int[] arr = RandArray(length);
PrintArray(arr);
int sum=Odd(arr);
Console.WriteLine($"Сумма элементов не нечетных позициях (индексах) равна {sum}");

int Odd(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)  sum+=arr[i];
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
        answer[i] = new Random().Next(0,3);
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