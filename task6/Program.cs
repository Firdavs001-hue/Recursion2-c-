//  Рекурсивно развернуть строку.

string ReversWord(string s, int index)
{
    if (index < 0)
    {
        return "";
    }

    return s[index] + ReversWord(s,index-1);
}
string s = "dddfff";
Console.Write(ReversWord(s, 5));


// string ReverseString(string s, int index)
//     {
//         if (index < 0)          // базовый случай
//             return "";

//         return s[index] + ReverseString(s, index - 1);
//     }

// string s = "dddfff";
// Console.Write(ReverseString(s, 5));