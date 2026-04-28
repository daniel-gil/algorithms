namespace SortingAlgorithms;

public class QuickSort : ISorter
{
    public void Sort(int[] array)
    {
        if (array.Length <= 1)
        {
            return;
        }
        
        var visited = new bool[array.Length];
        
        var isSorted = false;
        while (!isSorted)
        {
            // update the pivot and indexes
            var (startIndex, endIndex) = GetIndexes(array, visited);
            
            var pivotIndex = PivotIteration(array, startIndex, endIndex);
            
            // we mark the pivot index (endIndex) as visited
            visited[pivotIndex] = true;

            if (visited.All(x => x))
            {
                isSorted = true;
            }
        }
    }

    private static (int startIndex, int endIndex) GetIndexes(int[] array, bool[] visited)
    {
        int? startIndex = null, endIndex = null;
        
        for (var i = 0; i < array.Length; i++)
        {
            // initially we search for the first non-visited element
            if (startIndex is null && visited[i])
            {
                continue;
            }
            
            if (startIndex is null && !visited[i])
            {
                // here we found the first non-visited element, so we initialize both indexes to this index.
                // From now on we need just to take care of the endIndex
                startIndex = i;
                endIndex = i;
                continue;
            }
            
            if(startIndex is not null &&
               endIndex is not null &&
               visited[i])
            {
                // here we had a range initialized and found a stop condition (a visited node), we end our search here
                return (startIndex.Value, endIndex.Value);
            }
            
            if (endIndex is not null)
            {
                // here we had a range initialized and still in non-visited nodes, so we keep updating the endIndex
                endIndex = i;    
            }
        }

        return (startIndex!.Value, endIndex!.Value);
    }

    private static int PivotIteration(int[] array, int startIndex, int endIndex)
    {
        var pivotValue = array[endIndex];
        var (leftPartition, rightPartition) = BuildPartitions(array, pivotValue, startIndex, endIndex);
        var pivotIndex = UpdateArray(pivotValue, startIndex, leftPartition, rightPartition, array);
        return pivotIndex;
    }

    private static (List<int> leftPartition, List<int> rightPartition) BuildPartitions(
        int[] array,
        int pivotValue, 
        int startIndex, 
        int endIndex)
    {
        List<int> leftPartition = [];
        List<int> rightPartition = [];
        
        // notice that we are not processing the pivot index (endIndex)
        for (var i = startIndex; i < endIndex; i++)
        {
            if (array[i] < pivotValue)
            {
                leftPartition.Add(array[i]);
            }
            else
            {
                rightPartition.Add(array[i]);
            }
        }

        return (leftPartition, rightPartition);
    }

    private static int UpdateArray(
        int pivotValue,
        int startIndex, 
        List<int> leftPartition, 
        List<int> rightPartition, 
        int[] array)
    {
        var index = startIndex; 
        
        // first process the left partition
        for (var i = 0; i < leftPartition.Count; i++)
        {
            array[index++] = leftPartition[i];
        }
        
        // second process the pivot
        var pivotIndex = index;
        array[index++] = pivotValue;
        
        // finally process the right partition
        for (var i = 0; i < rightPartition.Count; i++)
        {
            array[index++] = rightPartition[i];
        }

        return pivotIndex;
    }
}