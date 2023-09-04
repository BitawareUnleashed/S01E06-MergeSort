int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
              11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
              21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
              31, 32, 33, 34, 35, 36, 37, 38, 39, 40,
              41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
              51, 52, 53, 54, 55, 56, 57, 58, 59, 60,
              61, 62, 63, 64, 65, 66, 67, 68, 69, 70,
              71, 72, 73, 74, 75, 76, 77, 78, 79, 80,
              81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
              91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };


Console.WriteLine("Array non ordinato:");
PrintArray(arr, 0, arr.Length - 1);
Console.WriteLine("\n");

MergeSort(arr, 0, arr.Length - 1);

Console.WriteLine("\nArray ordinato:");
PrintArray(arr, 0, arr.Length - 1);

Console.ReadLine();


static void MergeSort(int[] arr, int l, int r)
{
    if (l < r)
    {
        int m = l + (r - l) / 2;

        MergeSort(arr, l, m);
        MergeSort(arr, m + 1, r);

        Merge(arr, l, m, r);

        Console.WriteLine($"Fusione: left = {l}, middle = {m}, right = {r}");
        Console.Write("Array: ");
        PrintArray(arr, l, r);
        Console.WriteLine();
    }
}


static void Merge(int[] arr, int left, int middle, int right)
{
    int n1 = middle - left + 1;
    int n2 = right - middle;

    int[] leftArray = new int[n1];
    int[] rightArray = new int[n2];

    for (int i = 0; i < n1; i++)
        leftArray[i] = arr[left + i];
    for (int j = 0; j < n2; j++)
        rightArray[j] = arr[middle + 1 + j];

    int k = left;
    int iIdx = 0;
    int jIdx = 0;

    while (iIdx < n1 && jIdx < n2)
    {
        if (leftArray[iIdx] <= rightArray[jIdx])
        {
            arr[k] = leftArray[iIdx];
            iIdx++;
        }
        else
        {
            arr[k] = rightArray[jIdx];
            jIdx++;
        }
        k++;
    }

    while (iIdx < n1)
    {
        arr[k] = leftArray[iIdx];
        iIdx++;
        k++;
    }

    while (jIdx < n2)
    {
        arr[k] = rightArray[jIdx];
        jIdx++;
        k++;
    }
}


static void PrintArray(int[] arr, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(arr[i] + " ");
    }
}