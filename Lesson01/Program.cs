// Рекурсия. Показать натуральные числа от N до 1, N задано

void PrintNumber(int n)
{
    Console.Write(n + " ");
    n--;
    if(n == 0) return;
    PrintNumber(n);
}


Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine() ?? "0"); 
PrintNumber(N);



