// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму четных 
// элементов, стоящих на нечётных позициях 
// (позиция - индекс элемента в массиве).

Random x = new Random();

int N = 10;
int[] array = new int[N];
int sum = 0;

for (int i = 0; i < N; i++)
{
   array[i] = x.Next(1, 100);
   if((array[i] % 2 == 0) && (i % 2 != 0))
   {
        sum += array[i];
   }
}

var str = string.Join(" ", array);
Console.WriteLine($"[{str}] -> {sum}");
