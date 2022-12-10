
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите Массив");
int size =Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers();
Console.WriteLine("Наш массив");
PrintArray();
int count = 0;

for (int i = 0; i < numbers.Length; i++)
    
        if (numbers[i] % 2 == 0)
            count++;
        
        Console.WriteLine($"Количество {numbers.Length} чисел,{count} из них четные");





void FillArrayRandomNumbers()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 999);
    }
}



void PrintArray()
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

