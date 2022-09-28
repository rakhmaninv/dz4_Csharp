//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//* Написать калькулятор с операциями +, -, /, * и возведение в степень

double numA = UserNumberInput("Type number A: ");
double numB = UserNumberInput("Type number B: ");
string arOperator = ArithmeticOperatorChoice("Choose operator(+, -, *, / or ^): ");
double result = 0;

if (arOperator == "+") result = Addition(numA, numB);
else if (arOperator == "-") result = Subtraction(numA, numB);
else if (arOperator == "*") result = Multiplication(numA, numB);
else if (arOperator == "/") result = Division(numA, numB);
else if (arOperator == "^") result = RaisedToThePowerOf(numA, numB);
else Console.WriteLine("error");

Console.WriteLine("Result of {0} {1} {2} is {3}", numA, arOperator, numB, result);


double UserNumberInput(string msg)
{
    double userNumber;
    while (true)
    {
        try
        {
            Console.Write(msg);
            userNumber = Double.Parse(Console.ReadLine()!);
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Incorrect data entered");
        }
    }
    return userNumber;
}

string ArithmeticOperatorChoice(string msg)
{
    Console.Write(msg);
    string oper = Console.ReadLine() ?? "0";
    while (oper != "+" && oper != "-" && oper != "*"  && oper != "/" && oper != "^")
    {
        Console.Write("Incorrect simbol. Please type +, -, *, / or ^: ");
        oper = Console.ReadLine() ?? "0";
    }
    return oper;
}

double Addition(double numberA, double numberB)
{
    double sum = numberA + numberB;
    return sum;
}

double Subtraction(double numberA, double numberB)
{
    double difference = numberA - numberB;
    return difference;
}

double Multiplication(double numberA, double numberB)
{
    double product = numberA * numberB;
    return product;
}

double RaisedToThePowerOf(double numberA, double numberB)
{
    double power = numberA;
    if (numberB == 0) power = 1;
    else
    {
        for (double i = 1; i < numberB; i++)
        {
            power *= numberA;
        }
    }
    return power;
}

double Division(double numberA, double numberB)
{
    double quotient = 0;
    if (numberB == 0)
    {
        Console.WriteLine("Can't divide by 0");
        return quotient;
    }
    else quotient = numberA / numberB;
    return quotient;
}