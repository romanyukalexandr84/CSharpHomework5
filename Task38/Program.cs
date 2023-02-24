double Delta (int size)
{
double[] array = new double [size];

int i = 0;
Random random = new Random();

for (i = 0; i < size; i++)
{
    array[i] = Math.Round(random.NextDouble()*100, 2);
    Console.Write (array[i] + " ");
}

double max = array[0];
double min = array[0];

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
