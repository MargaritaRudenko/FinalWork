void FillArray(int[] arrayCreation)
{
    for(int i=0; i<arrayCreation.Length; i++)
    {
        arrayCreation[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] arrayOnScrean)
{
    for (int i = 0; i < arrayOnScrean.Length; i++)
    {
        Console.Write($"{arrayOnScrean[i]} ");
    }

}

void NewArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) Console.Write($"{array[i]} ");
    }
}