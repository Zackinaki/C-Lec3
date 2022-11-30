int[] arr={1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array)
{
    int count= array.Length;

    for(int i=0;i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[]array)
{
    for(int i=0; i<array.Length;i=i+1)
    {
        int minPosition=i;

        for(int j=i+1;j<array.Length;j++)
        {
            if(array[j]<array[minPosition])
            //if(array[j]>array[minPosition])
            minPosition=j;
        }
        int temporary= array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}

void SelectionSort1(int[]array)
{
    for(int i=0; i<array.Length;i=i+1)
    {
        int minPosition=i;

        for(int j=i+1;j<array.Length;j++)
        {
            //if(array[j]<array[minPosition])
            if(array[j]>array[minPosition])
            minPosition=j;
        }
        int temporary= array[i];
        array[i]=array[minPosition];
        array[minPosition]=temporary;
    }
}

PrintArray(arr);

Console.WriteLine();
SelectionSort(arr);
PrintArray(arr);

Console.WriteLine();
SelectionSort1(arr);
PrintArray(arr);
