int quantity (int size)
{
int[] array = new int [size];

int i = 0;
int count = 0;

for (i = 0; i < size; i++)
{
    array[i] = new Random().Next (100, 1000);
    Console.Write (array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}
Console.WriteLine ();
return count;
}

Console.WriteLine ("Задайте размерность массива");
int leng = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Количество четных чисел в массиве = "+quantity (leng));