// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max);
    }
    return answer;
}
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        Console.Write($"{array[count]} \t");
        count++;
    }
    Console.WriteLine();
}
int SumOddElements(int [] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        
        sum = sum + array[i];
    
    }
    return sum;
}

int [] array = GenerateArray(10, 2, 10);
PrintArray(array);
int sum = SumOddElements(array);
System.Console.WriteLine($"Сумма чисел с нечетными индексами в массиве равна {sum}");

