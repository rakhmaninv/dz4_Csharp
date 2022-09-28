// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

int number = UserNumberInput("Type a number: ");

DateTime startInt = DateTime.Now;
PrintData("Sum of digits of your number calculated by integer method is: {0}", IntSumOfDigits(number));
DateTime stopInt = DateTime.Now;
double timeInt = ((TimeSpan)(stopInt - startInt)).TotalMilliseconds;

DateTime startStr = DateTime.Now;
PrintData("Sum of digits of your number calculated by string method is: {0}", StringSumOfDigits(number));
DateTime stopStr = DateTime.Now;
double timeStr = ((TimeSpan)(stopStr - startStr)).TotalMilliseconds;

if (timeStr > timeInt) Console.WriteLine("Integer method is {0} times faster than string method", timeStr/timeInt);
else Console.WriteLine("String method is {0} times faster than integer method", timeInt/timeStr);



int UserNumberInput(string msg)
{
    int userNumber;
    while (true)
    {
        try
        {
            Console.Write(msg);
            userNumber = int.Parse(Console.ReadLine()!);
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    return userNumber;
}

int IntSumOfDigits(int value)
{
    int sum = 0;
    if (value < 0) value *= -1;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}

int StringSumOfDigits(int value)
{
    int sum = 0;
    if (value < 0) value *= -1;
    string numStr = value.ToString();
    for (int i = 0; i < numStr.Length; i++)
    {
        sum += numStr[i] - '0';
    }
    return sum;
}

void PrintData(string msg, int value)
{
    Console.WriteLine(msg, value);
}