/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */
string[] MinElementArray(string[] array)
{
int lenNewArray = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}
string[] newArray = new string[lenNewArray];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }  
}
return newArray;
}
void CreatingArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter element[{i}]: ");
          array[i] = Console.ReadLine();   
    }
}
void PrintArray(string[] array)
{
     Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}
Console.Write("Enter string array length: ");
int SizeArray = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string[SizeArray];
CreatingArray(myArray);
string[] NewArray = MinElementArray(myArray);
Console.WriteLine("Array with element's length <= 3:");
PrintArray(myArray);
Console.Write("-> ");
PrintArray(NewArray);