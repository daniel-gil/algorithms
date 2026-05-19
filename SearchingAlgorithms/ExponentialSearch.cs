namespace SearchingAlgorithms;

public class ExponentialSearch : ISearcher
{
    public int Search(int[] array, int target)
    {
        switch (array.Length)
        {
            case 0:
                return -1;
            case 1 when array[0] == target:
                return 0;
            case 1:
                return -1;
        }

        // represents the upper bound of the current block range
        var bound = 1;
        
        while (bound < array.Length && target > array[bound])
        {
            bound *= 2;
        }

        var start = bound / 2; // we don't need to do a linear search over the whole array
        var end = bound >= array.Length ? array.Length - 1 : bound;

        return BinarySearchRecursive.SearchRange(array, target, start, end);
    }
}