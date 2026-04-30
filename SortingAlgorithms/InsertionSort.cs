namespace SortingAlgorithms;

public class InsertionSort : ISorter
{
    public void Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            // already sorted, nothing to be done
            return;
        }
        
        // we start with index 1 because we know that processing the first item, it will end always in the first position
        for (var i = 1; i < array.Length; i++)
        {
            var currentValue = array[i];
            var insertionIndex = FindInsertionIndex(array, i, currentValue);
            
            // place the currentValue in the gap created at j+1 
            array[insertionIndex] = currentValue;
        }        
    }

    private static int FindInsertionIndex(int[] array, int i, int currentValue)
    {
        var j = i - 1;

        // Shift elements that are greater than currentValue one position to the right
        // The loop stops when j reaches -1 or array[j] is less than currentValue
        while (j >= 0 && array[j] > currentValue)
        {
            array[j + 1] = array[j]; // shift right
            j--;
        }

        return j + 1;
    }
}