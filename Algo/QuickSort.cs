namespace Grokking.Algo;

internal sealed class QuickSort
{
    public void Sort(int[] arr)
    {
        if (arr.Length < 2)
        {
            return;
        }

        int left = 0;
        int right = arr.Length - 1;
        Quick(arr, left, right);
    }

    private void Quick(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int partition = Partition(arr, left, right);
            Quick(arr, left, partition - 1);
            Quick(arr, partition + 1, right);
        }
    }

    private int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j <= right; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, right);
        return i + 1;
    }

    private void Swap(int[] arr, int left, int right)
    {
        int element = arr[left];
        arr[left] = arr[right];
        arr[right] = element;
    }
}