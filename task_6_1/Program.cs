/*  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3                                                             */

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    int num_result = int.Parse(Console.ReadLine()!);
    return num_result;
}

int[] GetArray(int len)
{
    int[] arr_result = new int[len];
    for (int j = 0; j < len; j++)
    {
        arr_result[j] = Prompt("Введите элемент массива: ");
    }
    return arr_result;
}

int NumberCount(int[] array)
{
    int num_count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) num_count++;
    }
    return num_count;
}

int len = Prompt("Введите размер массива: ");
int[] table = GetArray(len);

Console.WriteLine($"{string.Join(", ", table)} -> {NumberCount(table)}");