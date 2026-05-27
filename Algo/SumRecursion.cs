namespace Grokking.Algo;

internal sealed class SumRecursion
{
    public int Sum(int[] arr)
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

        return arr[index] + Calculate(arr, ++index);
    }
}