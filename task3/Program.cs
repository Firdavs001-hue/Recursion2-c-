// Реализовать рекурсивный поиск минимального элемента в массиве.

int FindMin(int[] arr, int index = 0)
{
    if(index == arr.Length - 1)
    {
        return arr[index];
    }

    int minOfRest = FindMin(arr, index+1);

    if(minOfRest > arr[index])
    {
        return arr[index];
    }
    else
    {
        return minOfRest;
    }
}

int[] ints = [2,3,55,6];
Console.Write(FindMin(ints, 0));
