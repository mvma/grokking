namespace Grokking.Algo;

internal sealed class CountRecursion
{
    public int Count(int[] arr)
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
            return 1;
        }

        return 1 + Calculate(arr, ++index);
    }
}