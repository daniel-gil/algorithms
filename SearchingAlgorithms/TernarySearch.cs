namespace SearchingAlgorithms;

public class TernarySearch : ISearcher
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
        
        // find middle points and compare them with the target
        var partitionSize = (end - start) / 3;
        var middle1Index = start + partitionSize;
        var middle1Value = array[middle1Index];
        
        var middle2Index = end - partitionSize;
        var middle2Value = array[middle2Index];
        
        if (middle1Value == target)
        {
            return middle1Index;
        }
        
        if (middle2Value == target)
        {
            return middle2Index;
        }
        
        if (target < middle1Value)
        {
            return SearchRange(array, target, start, middle1Index - 1);
        }  
        
        return target > middle2Value ? 
            SearchRange(array, target, middle2Index + 1, end) : 
            SearchRange(array, target, middle1Index + 1, middle2Index - 1);
    }
}