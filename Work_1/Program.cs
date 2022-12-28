// Написать программу, которая из имеющегося массива строк сформирует массив из строк
// длина которых меньше или равна 3 символа

void SearchElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] array1;
Console.WriteLine("Введите массив строк через пробел:");
string userstring = Console.ReadLine();
array1 = userstring.Split(' ');
string[] array2 = new string[array1.Length];
SearchElements(array1, array2);
PrintArray(array2);