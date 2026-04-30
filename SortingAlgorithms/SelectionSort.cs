namespace SortingAlgorithms;

public class SelectionSort : ISorter
{
    public void Sort(int[] array)
    {
        // the index 'i' represents the current index where to place the next smallest value
        for (var i = 0; i < array.Length; i++)
        {
            // find the minimum element in the remaining unsorted array [i+1, N-1]
            var minIndex = FindMinIndex(array, i);

            // if the value is already in the correct position, we can skip swapping
            if (minIndex != i)
            {
                // place the next smallest value in the correct place
                array.Swap(i, minIndex);   
            }
        }        
    }

    private static int FindMinIndex(int[] array, int offset)
    {
        // set to 'offset' to skip the already sorted elements 
        var minIndex = offset;
            
        // start at 'offset+1' to skip the first element, because minIndex was initialized to offset (first valid element to compare)
        for (var j = offset+1; j < array.Length; j++)
        {
            if (array[j] < array[minIndex])
            {
                minIndex = j;
            }
        }

        return minIndex;
    }
}