namespace SearchingAlgorithms;

public class JumpSearch : ISearcher
{
    public int Search(int[] array, int target)
    {
        var blockSize = (int)Math.Sqrt(array.Length);
        
        // pointer to the start of the current block
        var start = 0;
        
        while (start < array.Length)
        {
            // pointer to the next block
            var next = (start + blockSize) > array.Length ? array.Length : start + blockSize;
            
            if (target <= array[next - 1])
            {
                // here we found the block where the target would belong
                return BinarySearchRecursive.SearchRange(array, target, start, next-1);
            }
            
            start += blockSize;
        }
        
        return -1;
    }
}