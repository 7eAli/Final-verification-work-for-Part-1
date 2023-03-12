/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
   Длина которых меньше либо рана 3 символа. Первоначальный массив можно ввести с 
   Клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
   Пользоваться коллекциями, лучше обойтись исключительно массивами. */

string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int size = int.Parse(Console.ReadLine()!);
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] SortArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

