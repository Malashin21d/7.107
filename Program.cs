using System.Collections.Generic;

int ArrayQuantity;
Console.WriteLine("Введите колчичество значений в массив");
ArrayQuantity = int.Parse(Console.ReadLine());
if (ArrayQuantity > 0)// Ввод количества значений в таблице 
{
    int[] Array1 = new int[ArrayQuantity];
    int MinimumLimit;
    Console.WriteLine("Введите минимальное количество - не привышающие размер массива ");
    MinimumLimit = int.Parse(Console.ReadLine());
    Random rand = new Random();
   
        for (int i = 0; i < Array1.Length; i++)
        {
            Array1[i] = rand.Next(-10,10);
        }
    for (int i = 0; i < Array1.Length; i++)
    {
        Console.WriteLine(Array1[i]);
    }
    int NumberOfNegativeValues=0;
    for (int i = 0; i < Array1.Length; i++)
    {
        if (Array1[i] < 0)
        {
            NumberOfNegativeValues++;
        }
    }
    if (MinimumLimit < NumberOfNegativeValues ) 
    {
        Console.WriteLine("Колличество минусовых значений не преуменьшает {0}",MinimumLimit);
    }
    else
    {
        Console.WriteLine("Колличество минусовых значений преуменьшает {0}", MinimumLimit);
    }

}
else
{
    Console.WriteLine("ОШИБКА");
}