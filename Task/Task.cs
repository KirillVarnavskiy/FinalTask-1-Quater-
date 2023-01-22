// Задача :

// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Console.Clear();
string[] array1;
Console.WriteLine("Enter an array string separated by a space");
string stroka = Console.ReadLine();
array1 = stroka.Split(' ');

string[] array2 = new string[array1.Length];
int count = 0;
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(array1, array2);
PrintArray(array2);