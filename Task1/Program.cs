// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество чисел в массиве");

int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];


void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        Console.WriteLine(array[i]);
    }

}

void PositivNumber(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        result++;
    }
    System.Console.WriteLine($"всего чисел {array.Length}, {result} из них чётные");
    
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); // через пробел
    }
    Console.WriteLine();
}

FullArray(array);
PositivNumber(array);
PrintArray(array);