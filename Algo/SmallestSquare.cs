namespace Grokking.Algo;

internal sealed class SmallestSquare
{
    public int Calculate(int w, int h)
    {
        if (Max(w, h) % Min(w, h) == 0)
        {
            return Min(w, h);
        }

        if (w > h)
        {
            w = w % h;
        }
        else
        {
            h = h % w;
        }

        return Calculate(w, h);
    }

    private int Min(int i, int j)
    {
        if (i > j)
        {
            return j;
        }

        return i;
    }

    public int Max(int i, int j)
    {
        if (i > j)
        {
            return i;
        }

        return j;
    }
}