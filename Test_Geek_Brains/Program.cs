Console.WriteLine("Введите текст. Для разделения слов используйте пробелы (в том числе, после знаков препинания): ");
string text = Console.ReadLine();
Console.WriteLine("Введите количество символов. Слова с таким или меньшим количеством символов будут выведены на экран: ");
int Characters = int.Parse(Console.ReadLine());

string[] CreateArray(string N)
{
    string[] array = N.Split(' ');

    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("'");

        Console.Write(array[i] + "'");

        Console.Write(" ");
    }
}
