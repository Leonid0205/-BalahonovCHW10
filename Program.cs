// Задайте массив строк. Напишите программу, считает кол-во слов в массиве,
// начинающихся на гласную букву.   a, e, i, o, u, y
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] CreateStringArray(int numberOfStrings)
{
    string[] array = new string[numberOfStrings];
    for (int i = 0; i < numberOfStrings; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int ShowNumberOfWords(string[] array, char a, char e, char i, char o, char u, char y)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j][0] == a || 
            array[j][0] == e || 
            array[j][0] == i || 
            array[j][0] == o ||
            array[j][0] == u ||
            array[j][0] == y)
        {
            count++;
        }
    }
    return count;
}
Console.Write("How mane strings you want to input: ");
int numberOfStrings = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(numberOfStrings);
ShowStringArray(array);
Console.Write($"Number of words that starts from vowel is: {ShowNumberOfWords(array, 'a', 'e', 'i', 'o', 'u', 'y')}");
Console.WriteLine();

// Задайте массив строк. Напишите программу, которая генерирует новый массив,
// объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] CreateStringArray2(int numberOfStrings2)
{
    string[] array = new string[numberOfStrings2];
    if (numberOfStrings2 % 2 != 0)
    {
        Console.WriteLine("The number of words needs to be even!");
        return array;
    }
    for (int i = 0; i < numberOfStrings2; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
void ShowArray2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
string[] MergeStringsOfArray(string[] array)
{
    string[] arrayRes = new string[array.Length];
    if (array.Length % 2 != 0)
    {
        return array;
    }
    for (int i = 0, j = 0, k = 1; i < array.Length; i+=2, j+=2, k+=2)
    {
        arrayRes[i] = array[j] + array[k];
    }
    return arrayRes;
}
Console.WriteLine();
Console.Write("How many strings you want to input: ");
int numberOfStrings2 = Convert.ToInt32(Console.ReadLine());
string[] array1 = CreateStringArray2(numberOfStrings2);
ShowArray2(array1);
string[] arrayMerge = MergeStringsOfArray(array1);
ShowArray2(arrayMerge);
