int Sum (int size)
{
int[] array = new int [size];

int i = 0;
int total = 0;

for (i = 0; i < size; i++)
{
    array[i] = new Random().Next (-99, 100);
    Console.Write (array[i] + " ");
    if (i % 2 != 0)
    {
        total = total + array[i];
    }
}
Console.WriteLine ();
return total;
}

Console.WriteLine ("Задайте размерность массива");
int leng = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Сумма элементов, стоящих на нечётных позициях = "+Sum (leng));