namespace SearchingAlgorithmsBenchmarks;

public static class ArrayGenerator
{
    public static int[] GenerateRandomSortedUniqueArray(int length)
    {
        var rand = new Random(42);

        var values = new HashSet<int>();

        while (values.Count < length)
        {
            values.Add(rand.Next());
        }

        var array = values.ToArray();

        Array.Sort(array);

        return array;
    }
}