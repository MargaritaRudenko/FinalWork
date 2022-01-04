void FillArray(int[] arrayCreation)
{
    for(int i=0; i<arrayCreation.Length; i++)
    {
        arrayCreation[i] = new Random().Next(1, 100);
    }
}