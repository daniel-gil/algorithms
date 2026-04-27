namespace SortingAlgorithms;

public class BubbleSort : ISorter
{
    public void Sort(int[] array)
    {
        for (var i = 0; i < array.Length - 1; i++)
        {
            var isSorted = true;

            // because at the end of each iteration the next largest item bubbles up
            // and moves to its correct position, so we don't need to compare until 
            // the end of the array, just compare with all the items are not in the correct position
            var endIndex = array.Length - 1 - i;
            
            for (var j = 0; j < endIndex; j++)
            {
                // both values are already sorted, nothing to do here
                if (array[j] <= array[j + 1]) continue;
            
                // the pair of values are in the wrong order, we need to swap them
                array.Swap( j, j + 1);
                isSorted = false;
            }
            
            if (isSorted)
            {
                // if in the current iteration we didn't swap any element we assume the array is already sorted
                break;
            }
        } 
    }
}