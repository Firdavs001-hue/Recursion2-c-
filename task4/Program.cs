// Посчитать количество элементов массива рекурсивно.

int arrLength(int[] numbers, int index = 0)
{
    if (numbers.Length == index)
    {
        return 0; 
    }
    return 1+ arrLength(numbers, index+1);
}

int[] arr = [5,4,5,6,810,0];
Console.Write(arrLength(arr,0));
