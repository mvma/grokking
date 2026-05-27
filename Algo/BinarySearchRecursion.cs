namespace Grooking.Algo;

internal sealed class BinarySearchRecursion
{
    public int Search(int[] arr, int element)
    {
        int low = 0;
        int high = arr.Length - 1;
        int middle = (low + high) / 2;

        return Find(arr, low, high, middle, element);
    }

    private int Find(int[] arr, int low, int high, int middle, int element)
    {
        if (arr[middle] == element)
        {
            return middle;
        }

        if (low > high)
        {
            return -1;
        }

        if (low <= middle)
        {
            low = middle + 1;
        }
        else
        {
            high = middle - 1;
        }

        middle = (low + high) / 2;

        return Find(arr, low, high, middle, element);
    }
}