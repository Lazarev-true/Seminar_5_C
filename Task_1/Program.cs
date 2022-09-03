// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.


Console.WriteLine("Введите размер массива");
int N = Convert.ToInt32(Console.ReadLine());

Random x = new Random();

int[] array = new int[N];

int volume = 0;

for (int i = 0; i < N; i++)
{
   array[i] = x.Next(100, 1000);
   if(array[i] % 2 == 0)
   {
        volume += 1;
   }
}
var str = string.Join(" ", array);
Console.WriteLine($"[{str}] -> {volume}");
