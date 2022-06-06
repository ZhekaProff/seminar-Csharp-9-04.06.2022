// Рекурсия, Показать натуральные числа от 1 до N, N задано

void PrintNumber(int n) // от 1 до N
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}

void PrintNumbera(int n)  // от N до 1
{
    
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumbera(n - 1);
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0"); 

PrintNumber(N);
Console.WriteLine();
PrintNumbera(N);
