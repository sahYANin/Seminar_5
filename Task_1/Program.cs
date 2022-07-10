/*
    Задача 34: 
    Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] Num = new int[3];
int s = 0;

for (int i = 0; i < 3; i++)
{
    Num[i] = new Random().Next(100, 1000);
}
Console.WriteLine("[" + string.Join(",", Num) + "]");
for (int i = 0; i < 3; i++)
{
    if(Num[i]%2==0)s++;
}
if(s==0) Console.WriteLine("Увы нету четных чисел");
else
{
    Console.Write("Kоличество чётных чисел в массиве: ");
    Console.Write(s);
}