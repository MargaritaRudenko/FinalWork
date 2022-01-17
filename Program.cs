void FillArray(int[] arrayCreation, int minValue, int maxValue)
{
    for(int i=0; i<arrayCreation.Length; i++)
    {
        arrayCreation[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] arrayOnScrean)
{
    for (int i = 0; i < arrayOnScrean.Length; i++)
    {
        Console.Write($"{arrayOnScrean[i]} ");
    }

}

int [] array = new int[10];
FillArray(array, -100, 100);
PrintArray(array);

Console.WriteLine();

int Total (int[] array)
{
    int totalNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) totalNumber++;
       
    }
    return totalNumber;
}

int[] NewArray (int[] array, int totalNumber)
{
    int[] newArray = new int [totalNumber];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            newArray[count] = array[i];
            count++;
        } 
    }
    return newArray;
  
}

PrintArray(NewArray(array, Total(array)));