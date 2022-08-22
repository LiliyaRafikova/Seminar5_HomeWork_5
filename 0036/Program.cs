// See https://aka.ms/new-console-template for more information
Console.WriteLine(" Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.!");
int size = 10;
int summaNegativIndex = 0;
int []Array = new int[size];
for (int i = 0; i < size; i++)
{
   Array [i]= new Random().Next(-9,10);

}
Console.WriteLine($"[{String.Join(", ", Array)}]");
for (int i = 1; i < size; i=i+2)
{
   summaNegativIndex+=Array[i];

}
Console.WriteLine(summaNegativIndex);