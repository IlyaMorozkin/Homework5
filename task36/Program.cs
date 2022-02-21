// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

double[] arr = new double[100];
int index = 0;
double even = 0;
double odd = 0;
void FillArray()
{
    for (int i =0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
}
FillArray();
while (index < arr.Length)
{
    if (arr[index] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
    index++;
}
Console.WriteLine($"Нечетные {odd} ");
Console.WriteLine($"Четные {even} ");