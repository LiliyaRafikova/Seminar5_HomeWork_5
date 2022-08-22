// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
int size = 5;
int count = 0;
int []Array = new int[size];
for (int i = 0; i < size; i++)
{
    Array [i]= new Random().Next(100,1000);
    if (Array[i]%2==0) count++;

}
Console.WriteLine($"[{String.Join(", ", Array)}]");
Console.WriteLine($"Количество четных элементов: {count}");