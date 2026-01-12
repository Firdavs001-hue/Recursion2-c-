// Проверить, является ли строка палиндромом с помощью рекурсии.

bool IsPalindrome(string s, int left, int right)
    {
    if (left >= right)          // базовый случай
        return true;

    if (s[left] != s[right])    // символы не совпадают
        return false;

    return IsPalindrome(s, left + 1, right - 1);
}
string s = "faaf";
Console.Write(IsPalindrome(s, 0,3));