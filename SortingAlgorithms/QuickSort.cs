namespace SortingAlgorithms;

public class QuickSort : ISorter
{
    public void Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }

        SortRange(array, 0, array.Length - 1);
    }
    
    private static void SortRange(int[] array, int start, int end)
    {
        if (start >= end)
        {
            // stop the recursion when:
            //    - (start==end) -> single item array
            //    - (start>end)  -> empty array
            return;
        }
        
        // calculate partitions
        var boundary = Partition(array, start, end);

        // sort left
        SortRange(array, start, boundary - 1);

        // sort right
        SortRange(array, boundary + 1, end);
    }

    // this returns the index of the pivot after it has been moved to its right position (sorted)
    // we assume that the pivot is the last element of the array 
    private static int Partition(int[] array, int start, int end)
    {
        var pivot = array[end];
        
        // The boundary marks the boundary of the left and right partitions (represents the end of the left partition).
        // On the first iteration it will be -1 meaning the left partition is empty
        var boundary = start - 1 ; 

        for (var i = start; i <= end; i++)
        {
            if(array[i] <= pivot)
            {
                array.Swap(i, ++boundary);
            }
        }
        
        return boundary;
    }
}