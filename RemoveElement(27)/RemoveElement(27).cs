public class RemoveElement_27_
{
    public int RemoveElement(int[] nums, int val)
    {
        int res = 0;
        foreach (var i in nums) { if (i != val) { nums[res] = i; res++; } }
        return res;
    }
}
