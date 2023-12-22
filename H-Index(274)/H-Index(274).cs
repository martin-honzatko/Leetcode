public class H_Index_274_
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);
        int n = citations.Length, start = 0, end = n - 1;
        while (start <= end)
        {
            int mid = start + ((end - start)/2), countOfEsInRightPlusCurrent = n - mid;

            if (citations[mid] == countOfEsInRightPlusCurrent) return citations[mid];
            else if (citations[mid] < countOfEsInRightPlusCurrent) start = mid + 1;
            else end = mid - 1;
        }
        return (n - start);
    }
}
