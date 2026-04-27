namespace SortingAlgorithms;

public class BubbleSort : ISorter
{
    public void Sort(int[] array)
    {
        while (!IterationSort(array))
        { }
    }

    private static bool IterationSort(int[] array)
    {
        var sorted = true;

        for (var i = 0; i < array.Length-1; i++)
        {
            if (array[i] <= array[i + 1]) continue;
            
            Swap(array, i, i + 1);
            sorted = false;
        }
        
        return sorted;
    }

    private static void Swap(int[] array, int i, int j)
    {
        var tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}