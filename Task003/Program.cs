// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7.3 22.2 2 78] -> 76



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
int DecisionElements(int [] array)
{
    int decision = 0;
    int maxNumber = array[0];
    int minNumber = array[0];
    for(int i=0; i < array.Length; i++)
    {
        if(maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if(minNumber > array[i])
        {
            minNumber = array[i];
        }

        decision = maxNumber - minNumber;
    }
    return decision;
    
}
int [] array = GenerateArray(3, 2, 10);
PrintArray(array);
int decision = DecisionElements(array);
System.Console.WriteLine($"Разница между максимальным и минимальным значением в массиве равна {decision} ");
