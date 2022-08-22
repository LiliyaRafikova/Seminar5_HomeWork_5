Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
double []Array= new double[5];
for (int i=0; i<Array.Length; i++)
{
    Array[i]= (new Random().NextDouble())*100;
    Array[i]= Math.Round(Array[i],2);
}
double maxElements=Array[0];
double minElements=Array[0];
double result = 0;
for (int i=0; i<Array.Length; i++)
{
    if (minElements>Array[i]) minElements=Array[i];
    if (maxElements<Array[i]) maxElements=Array[i];
}
Console.WriteLine($"[{String.Join(";  ", Array)}]"); 
Console.WriteLine($"Max = {maxElements}");
Console.WriteLine($"Min = {minElements}");
result = maxElements-minElements;
result =Math.Round(result,2);
Console.WriteLine(result);