// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите Массив");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers();
Console.WriteLine("Наш Массив");
PrintArray();
int sum = 0;

for (int i = 0; i < numbers.Length; i += 2)
    sum = sum + numbers[i];
Console.WriteLine($"всего{numbers.Length} чисел,сумма элементов на нечетных позициях = {sum}");


void FillArrayRandomNumbers()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
    
}

void PrintArray()
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("] ");
    Console.WriteLine();
}