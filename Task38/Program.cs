int Delta (int size)
{
int[] array = new int [size];

int i = 0;

for (i = 0; i < size; i++)
{
    array[i] = new Random().Next (-99, 100);
    Console.Write (array[i] + " ");
}

int max = array[0];
int min = array[0];

for (i = 1; i < size; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine ();
return max-min;
}

Console.WriteLine ("Задайте размерность массива");
int leng = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Разница между max и min элементами массива = "+Delta (leng));
