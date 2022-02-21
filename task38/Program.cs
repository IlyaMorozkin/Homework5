// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] arr = new int[20];
int sum = 0;
int count =1;
void FillArray()
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 20);
        Console.Write($"{arr[i]} ");
    }
}
void PrintSum()
{
    while (count <= arr.Length)
    {
        sum+= arr[count];
        count = count +2;
    }
    Console.Write($"\nСумма чисел на не четных позициях = {sum}");
}

Console.WriteLine("Сгенерированный массив: ");
FillArray();
PrintSum();