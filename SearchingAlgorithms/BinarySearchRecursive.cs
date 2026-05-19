namespace SearchingAlgorithms;

public class BinarySearchRecursive : ISearcher
{
    public int Search(int[] array, int target)
    {
        return SearchRange(array, target, 0, array.Length - 1);
    }
    
    private static int SearchRange(int[] array, int target, int start, int end)
    {
        if (start > end)
        {
            return -1;
        }
        
        // find middle point and compare it with the target
        var middleIndex = start + ((end - start) / 2); // avoid overflow for huge arrays, instead of "(start + end) / 2"
        var middleValue = array[middleIndex];

        if (middleValue == target)
        {
            return middleIndex;
        }

        return target < middleValue ? 
            SearchRange(array, target, start, middleIndex - 1) : 
            SearchRange(array, target, middleIndex + 1, end);
    }
}