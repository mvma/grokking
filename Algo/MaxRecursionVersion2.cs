namespace Grooking.Algo;

internal sealed class MaxRecursionVersion2
{
    public int Max(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        int index = 0;
        return Calculate(arr, index);
    }

    private int Calculate(int[] arr, int index)
    {
        if (index == arr.Length - 1)
        {
            return arr[index];
        }

        int current = arr[index];
        int next = Calculate(arr, ++index);
        if (current > next)
        {
            return current;
        }
        return next;
    }
}