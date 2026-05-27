namespace Grokking.Algo;

internal sealed class MaxRecursion
{
    public int Max(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }

        int max = arr[0];
        int index = 1;
        return Calculate(arr, index, max);
    }

    private int Calculate(int[] arr, int index, int max)
    {
        if (index > arr.Length - 1)
        {
            return max;
        }

        int current = arr[index];
        if (current > max)
        {
            max = current;
        }

        return Calculate(arr, ++index, max);
    }
}