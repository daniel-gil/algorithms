namespace SortingAlgorithms;

public static class SortExtensions
{
    public static void Swap(this int[] array, int i, int j)
    {
        var tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}