// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] FillArray()
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.WriteLine($"{array[i]} ]\n");
    }
}

int[] ProduktPairsNumber(int[] array)
{
    int[] newArray = new int[size / 2 + size % 2];
    for (int i = 0; i < newArray.Length; i++)
    {
        if (i == array.Length - 1 - i)
            newArray[i] = array[i];
        else
            newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newArray;
}

int[] massiv = FillArray();
PrintArray(massiv);
int [] newMassiv = ProduktPairsNumber(massiv);
PrintArray(newMassiv);



