using NetTopLevelConsoleApp;

int size = 10;
int[] array = new int[size];

//for (int i = 0; i < array.Length; i++)
//    array[i] = (i + 1) * 10;

ArrayPrint(array);

ArrayRandomInit(array);
ArrayPrint(array);
ArrayReversePrint(array);

foreach(int item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine();

void ArrayPrint(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void ArrayReversePrint(int[] array)
{
    for(int i = 1; i <= array.Length; i++)
        Console.Write($"{array[^i]} ");
    Console.WriteLine();
}

void ArrayRandomInit(int[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = random.Next(0, 100);
}