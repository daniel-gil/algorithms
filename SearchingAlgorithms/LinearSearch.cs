namespace SearchingAlgorithms;

public class LinearSearch : ISearcher
{
    public int Search(int[] array, int target)
    {
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}