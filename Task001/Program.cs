//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


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


int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 0)
    {
      quantity++;
    }
  }
  return quantity;
}
int [] array = GenerateArray(3, 100, 1000);
PrintArray(array);
int quantity = QuantityPositive(array);
System.Console.WriteLine($"Количество четных чисел в массиве равно {quantity}");