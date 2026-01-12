// Проверить, отсортирован ли массив по возрастанию рекурсивно.

bool IsIncreasArr(int[] arr, int index = 0)
{
    if(index == arr.Length-1)
    {
        return true;
    }
    if (arr[index] > arr[index + 1])
    {
        return false;
    }

    return IsIncreasArr(arr, index+1);
}

int[] ints = [1, 2, 4, 5, 20];
Console.Write(IsIncreasArr(ints, 0));
