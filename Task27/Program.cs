// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Method(int Number)
{
    int SumNum = 0;
    int FirstNumber = Number; //Эта переменная нужна для аккуратного вывода числа(можно сделать чтобы в цикле использовалась переменная FirstNumber, 
                              //но я решил чтобы она использовалась в конце кода).
    while (Number != 0)
    {
        int LastNum = Number % 10;
        SumNum = SumNum + LastNum;
        Number = Number / 10;
    }
    Console.WriteLine($"{FirstNumber} -> {SumNum}");
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int Number = int.Parse(Console.ReadLine());
    return (Number);
}

//Ввод данных пользователя 
int Number = GetNum("Введите число: ");

//Метод cуммирования цифр в числе
Method(Number);