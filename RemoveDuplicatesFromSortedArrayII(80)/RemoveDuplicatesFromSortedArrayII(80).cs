public class RemoveDuplicatesFromSortedArrayII_80_
{
    public int RemoveDuplicates(int[] nums)
    {
        int pos = 1, count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            count = (nums[i] == nums[i - 1]) ? (count + 1) : 0;
            if (count < 2) nums[pos++] = nums[i];
        }
        return pos;
    }
}
