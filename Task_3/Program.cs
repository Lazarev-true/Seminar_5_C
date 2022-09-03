// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.

Random x = new Random();

int start = 1;
int stop = 30;
int N = 5;
int[] array = new int[N];
int min = stop;
int max = start;

for (int i = 0; i < N; i++)
{
   array[i] = x.Next(start, stop);
   if(max <= array[i])
   {
        max = array[i];
   }
   if(min >= array[i])
   {
        min = array[i];
   }
}

int difference = max - min;

var str = string.Join(" ", array);
Console.WriteLine($"[{str}] -> {difference}");
