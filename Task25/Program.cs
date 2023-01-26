// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Method(int NumberA, int NumberB)
{
    int NumberAWork = NumberA; //Эта переменная нужна для аккуратного вывода числа
    for (int i = 1; i < NumberB; i++)
    {
        NumberAWork = NumberAWork * NumberA;
    }
    Console.WriteLine($"{NumberA}, {NumberB} -> {NumberAWork}");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

//Ввод данных пользователя 
int NumberA = GetNum("Введите значение А: ");
int NumberB = GetNum("Введите значение B: ");

//Метод возведения в степень
Method(NumberA, NumberB);