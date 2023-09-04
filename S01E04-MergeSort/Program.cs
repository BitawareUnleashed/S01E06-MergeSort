int[] arr = { 17, 92, 5, 33, 68, 7, 56, 40, 24, 87,
              2, 13, 61, 98, 35, 75, 11, 26, 47, 99,
              31, 82, 49, 74, 6, 19, 51, 89, 70, 44,
              16, 94, 30, 83, 1, 38, 71, 57, 41, 55,
              3, 22, 66, 72, 36, 14, 8, 69, 95, 46,
              15, 73, 21, 59, 9, 29, 85, 64, 77, 78,
              50, 28, 67, 34, 76, 62, 45, 79, 91, 10,
              60, 84, 20, 23, 4, 27, 18, 54, 25, 81,
              63, 86, 58, 80, 42, 93, 12, 48, 53, 88,
              37, 96, 52, 97, 32, 65, 90, 43, 39, 100 };



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