// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество чисел в массиве");

int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
        Console.WriteLine(array[i]);
    }
}

void PositivNumber(int[] array)
{
    double result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        result++;
        result = result + result;
    }
    
    System.Console.WriteLine($"всего чисел {array.Length}, {result} из них не чётные");
    
}




FullArray(array);
PositivNumber(array);
