/*
В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел массива data
с учётом информации из массива info.
входные данные: data = {(0, 1,) (1, 1, 1,) (0, 0, 0), (1) } info = {2, (3), 3, 1 }выходные данные: 1, (7), 0, 1
*//*
int[] Convertеr(int[] binary, int[] bitCount)
{
    int number = 0;
    int j = 0;
    for (int i = 0; i < binary.Length; i++)
    {
        if (bitCount[j] == 0)
        {
            bitCount[j] = number;
            number = 0;
            j++;
        }
        else
        {
            number = number + (int)Math.Pow(2, --(bitCount[j])) * binary[i];
        }
    }
    return bitCount;
}*/
int[] Convertеr(int[] binary, int[] bitCount)
{
    int number = 0;
    for (int j = 0; j < binary.Length; j++)
    {
        for (int i = 0; i < bitCounter[]; i++)
        {
            if (bitCount[j] == 0)
            {
                bitCount[j] = number;
                number = 0;
                j++;
            }
            else
            {
                number = number + (int)Math.Pow(2, --(bitCount[j])) * binary[i];
            }
        }
    return bitCount;
}
Console.Clear();
int[] binary = { 0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] bitCount = { 2, 3, 3, 1};
Console.WriteLine(string.Join(", ", Convertеr(binary, bitCount)));


