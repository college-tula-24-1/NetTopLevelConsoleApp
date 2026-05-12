using NetTopLevelConsoleApp;

int size = 10;
int[] array = new int[size];

//for (int i = 0; i < array.Length; i++)
//    array[i] = (i + 1) * 10;

ArrayPrint(array);

ArrayRandomInit(array);
ArrayPrint(array);
ArrayReversePrint(array);

int p = 5;
double x = 3.5;
double y = Power(p, x);

int n = 20;
int m = 30;
Console.WriteLine($"n = {n}, m = {m}");
Swap(ref n, ref m);
Console.WriteLine($"n = {n}, m = {m}");

int f;
Func(out f);

WayType wt = WayType.Down;


foreach (int item in array)
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

double Power(int level, double x)
{
    if (level == 0) return 1;
    return Power(level - 1, x) * x;
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void InFunc(in int val)
//void InFunc(ref readonly int val)
{
    //val = 100; // error
    Console.WriteLine($"Value = {val}");
}

void Func(out int a)
{
    a = 100;
}

enum WayType
{
    Up = 10,
    Down = 20,
    Left,
    Right
}