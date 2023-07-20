string[] FillNewArray(string[] arr, string[] newArr, int standard)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= standard)
        {
            newArr[count] = arr[i];
            count++;
        }
    }
    return newArr;
}
FillNewArray(array, newArray, standardSize);
Console.WriteLine(string.Join(", ", newArray));
string[] newArray = new string[ElementCounting(array, standardSize)];