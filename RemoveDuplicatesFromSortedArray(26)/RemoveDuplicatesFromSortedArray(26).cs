public class RemoveDuplicatesFromSortedArray_26_
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1, l = nums[0];
        for (int i = 1; i < nums.Length; i++) { if (nums[i] != l) { nums[k] = nums[i]; k++; } l = nums[i]; }
        return k;
    }
}
