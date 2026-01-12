// Написать рекурсивный метод для вычисления числа Фибоначчи.

int Fibonachi(int n)
{
    if(n<=1) return 1;
    return Fibonachi(n-1) + Fibonachi(n-2);
}

Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("The answer is: ");
Console.WriteLine(Fibonachi(n));