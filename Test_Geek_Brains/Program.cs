
























int Counter(string[] array, int Quantity)

{

int count = 0;

for (int i = 0; i < array.Length; i++)

{

if (array[i].Length <= Quantity)

{

count++;

}

}

return count;

}