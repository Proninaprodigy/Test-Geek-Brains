
















































string[] CreateArrayCharacters(string[] array, int Quantity, int size)

{

string[] ReceivedArray = new string[size];

int n = 0;

for (int m = 0; m < array.Length; m++)

{

if (array[m].Length <= Quantity)

{

ReceivedArray[n] = array[m];

n++;

}

}

return ReceivedArray;

}

CreateArray(text);

PrintArray(CreateArray(text));

Console.Write("--> ");

int count = Counter(CreateArray(text), Characters);

CreateArrayCharacters(CreateArray(text), Characters, count);

PrintArray(CreateArrayCharacters(CreateArray(text), Characters, count));

Console.WriteLine();
