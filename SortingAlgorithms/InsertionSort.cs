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
            
            if (insertionIndex >= 0)
            {
                // move the current value where it belongs
                array[insertionIndex] = currentValue;
            }
        }        
    }

    private static int FindInsertionIndex(int[] array, int i, int currentValue)
    {
        var currentIndex = i;
        var tmpIndex = i;
            
        for (var j = i - 1; j >= 0; j--)
        {
            if (array[j] <= currentValue) continue;
                
            array[tmpIndex--] = array[j];
                    
            // after shifting the value to the right, we left place to potentially insert the current value
            currentIndex = j;
        }

        return (currentIndex == i) ? -1 : currentIndex;
    }
}