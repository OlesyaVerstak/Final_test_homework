// Написать программу которая из имеющегося массива строк формируют массив из строк длина которых меньше либо равна 3 символа. 
string[] incomingArray;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
incomingArray = stroka.Split(' ');
string[] outgoingArray = new string[incomingArray.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(incomingArray, outgoingArray);
PrintArray(outgoingArray);