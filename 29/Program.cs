// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

int arrayLen = UserNumberInput("Type array lenght: ");
int minArrayElement = UserNumberInput("Type minimum array element: ");
int maxArrayElement = UserNumberInput("Type maximum array element: ");

int[] array = CreateArray(arrayLen, minArrayElement, maxArrayElement);
PrintArray(array);

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

int[] CreateArray(int len, int elMin, int elMax)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(elMin, elMax + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b" + "\b");
    Console.Write("]");
}