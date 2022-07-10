/*
    Задача 38: 
    Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
*/

int mi=1001,mx=-100,pi;

Console.Write("Введите количество элементов в массиве: ");
pi = Convert.ToInt32(Console.ReadLine());
int[] Num = new int[pi];

for (int i = 0; i < pi; i++)
{
    Num[i] = new Random().Next(-100, 1001);
    if(mx<Num[i])mx=Num[i];
    if(mi>Num[i])mi=Num[i];
    // Console.WriteLine(mi);
}
Console.WriteLine("[" + string.Join(",", Num) + "]");

Console.Write("Разница между максимальным и минимальным: ");
Console.WriteLine(mx-mi);


// Console.WriteLine(mx);
// Console.WriteLine(mi);