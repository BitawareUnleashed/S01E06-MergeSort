int[] arr = { 5, 2, 8, 4, 1, 10, 9, 6, 7, 3 };

Console.WriteLine("Array non ordinato:");
PrintArray(arr, 0, arr.Length - 1);
Console.WriteLine("\n");

MergeSort(arr, 0, arr.Length - 1);

Console.WriteLine("\nArray ordinato:");
PrintArray(arr, 0, arr.Length - 1);

Console.ReadLine();



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

static void PrintArray(int[] arr, int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(arr[i] + " ");
    }
}