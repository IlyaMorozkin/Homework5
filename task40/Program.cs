// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int n = 10;
double[] array = new double[n];
double max = array[0], min = 0;
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rand.NextDouble()*100;
    if (max >= array[i])
        min = array[i];
    else
        max = array[i];
    Console.Write($"{array[i]} ");

}
for (int j = 0; j < n; j++)
{
    if (min > array[j])
        min = array[j];

}
double difference = max - min;
Console.WriteLine($"\nМаксимальное число = {max} ");
Console.WriteLine($"Минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным числом = {difference}");