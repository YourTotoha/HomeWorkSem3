// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] Array)
{
    int Length = Array.Length;
    for (int i = 0; i < Length - 1; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.Write($"{Array[Length - 1]} ");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

int Number = GetNum("Введите количество элементов в массиве: ");

int[] Arr = new int[Number];

for (int i = 0; i < Number; i++)
{
    Arr[i] = new Random().Next(0, 100);
}

PrintArray(Arr);