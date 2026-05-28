namespace Grooking.Algo;

internal sealed class HashFunction
{
    private Dictionary<char, int> _map = new Dictionary<char, int>
    {
        {'a', 2},{'b', 3}, {'c', 5}, {'d', 7}, {'e', 11},
        {'f', 13}, {'g',17},{'h',19},{'i',23}, {'j',29},
        {'k',31},{'l',37},{'m',41},{'n',43},{'o',47},
        {'p',53},{'q',59},{'r',61},{'s',67},{'t',71},
        {'u',73},{'v',79},{'w',83},{'x',89},{'y',97},
        {'z',101}
    };

    public int Hash(string word, int slots)
    {
        word = word.ToLower();
        int total = 0;
        for (int i = 0; i <= word.Length - 1; i++)
        {
            if (_map.ContainsKey(word[i]))
            {
                total += _map[word[i]];
            }
        }

        return total % slots;
    }
}