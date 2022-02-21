// Написать программу замену элементов массива на противоположные

int[] array = new int[20];
Random rand = new Random();
void FillArray(int[] arr)

{
    int position = 0;
    while (position < arr.Length)
    {
        arr[position]= rand.Next(-20, 20);
        Console.Write($"{arr[position]} ");
        position++;
    }
}    
void SubstitutionNumber(int[] arr)
{
    for(int index=0; index < arr.Length; index++)
    {
        arr[index] = arr[index] * -1;
        Console.Write($"{arr[index]} ");
    }
}

Console.WriteLine("Изначальный массив: ");
FillArray(array);
Console.WriteLine();
Console.WriteLine("Противоположный массив: ");
SubstitutionNumber(array);