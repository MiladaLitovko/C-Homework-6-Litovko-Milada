/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


Zadacha41();

void Zadacha41()
{
    Console.Write($"Введите количество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    PositiveNumbers(array);
}

void PositiveNumbers(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine($"Количество чисел больше 0 в массиве равно: {sum}");
}



//Вариант с рандомным заполнением массива
/*void FillArray(int[] array, int startNumber = 0, int finishNumber = 0)
{
    finishNumber++;
    Random random = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}
*/

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1} число массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

