namespace Grokking.Algo;

internal sealed class BinarySearch
{
    public int Iterations { get; private set; }

    public int Search(int[] array, int element)
    {
        Iterations = 0;

        int low = 0;
        int high = array.Length - 1;

        while (low <= high)
        {
            Iterations++;

            int middle = (low + high) / 2;
            if (array[middle] == element)
            {
                return middle;
            }
            else if (low <= middle)
            {
                low = middle + 1;
            }
            else
            {
                high = middle - 1;
            }
        }

        return -1;
    }
}