internal class MajorityElement_169_
{
    internal int MajorityElement(int[] nums)
    {
        int cand = nums[0], count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                cand = nums[i];
                count = 1;
            }
            else if (cand == nums[i]) count++;
            else count--;
        }

        return cand;
    }
}
