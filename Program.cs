
string[] array = {"hello", "2", "world",":-)","sts","123asd","pasport","yes","P"};

string[] Create3ElementArray(string[] array, int elementLenght = 3)
{
    int lengthNewArray = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length <= elementLenght) lengthNewArray++;

    string[] newArray = new string[lengthNewArray];

    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <= elementLenght)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("'" + array[i] + "'");
        if(i < array.Length -1) Console.Write(",");
    }
    Console.WriteLine();
}

Console.WriteLine("Default array:");
PrintStringArray(array);
string[] newStringArray = Create3ElementArray(array);
Console.WriteLine("New array:");
PrintStringArray(newStringArray);