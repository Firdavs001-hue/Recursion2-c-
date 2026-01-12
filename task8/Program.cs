// Используя рекурсию, найдите **сумму цифр числа**, пока результат не станет однозначным.

// int SumDigit(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }

//     return n%10 + SumDigit(n/10);
// }

// int OneDigit(int s)
// {
//     if(s<10) return s;

//     return OneDigit(SumDigit(s));
// }

// int s = SumDigit(999999);
// Console.WriteLine(OneDigit(s));

int DigitalRoot(int n)
    {
        n = Math.Abs(n); // на случай отрицательного числа

        while (n >= 10) // пока число не однозначное
        {
            int sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            n = sum;
        }

        return n;
    }

Console.Write(DigitalRoot(999991));