void FillArray(int[] arr, int start, int end)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
}
int[] CreateRandomArray(int size, int start, int end)
{
    int[] result = new int[size];
    FillArray(result, start, end);
    return result;
}
int[] arr = CreateRandomArray(10, 1, 100);
Console.WriteLine($"[{string.Join(", ", arr)}]");
int count = 0;
for (int i=0; i<arr.Length; i++)
    {
      if (arr[i]>= 20 && arr[i]<=90)
      {
        count++;
      }
    }
Console.WriteLine($"Число элементов массива arr лежащих в [20, 90] {count} штук");