/*
    Задача 36: 
    Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
int pi, n = 0, s = 0;
Console.Write("Введите количество элементов в массиве: ");
pi = Convert.ToInt32(Console.ReadLine());
int[] Num = new int[pi];

Console.Write("Сумма чётных(2) или нечётных(1)?: ");
n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0) n = 1;
else n = 0;

// Console.WriteLine(n);
for (int i = 0; i < pi; i++)
{
    Num[i] = new Random().Next(-100, 1001);
}
Console.WriteLine("[" + string.Join(",", Num) + "]");

for (; n < pi; n++)
{
    s = s + Num[n];
    n++;
}

Console.Write("Сумма: ");
Console.WriteLine(s);