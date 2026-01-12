// Реализовать рекурсивный поиск максимального элемента в массиве.
int FindMax(int[] array, int index = 0)
{
    // Базовый случай: последний элемент [2,3,55,6]
    if (index == array.Length - 1) //3 3  
        return array[index];

    // Рекурсивный вызов
    int maxOfRest = FindMax(array, index + 1);

    // Сравнение текущего элемента с максимумом
    if (array[index] > maxOfRest)
    {
        return array[index];
    }
    else
    {
        return maxOfRest;
    }
}

int[] ints = [2,3,55,6];
Console.Write(FindMax(ints, 0));