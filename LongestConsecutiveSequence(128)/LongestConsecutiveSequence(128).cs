public class LongestConsecutiveSequence_128_
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;
        int streak = 1, longest = 1;
        nums = nums.ToHashSet<int>().ToArray();
        Array.Sort(nums);

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1)
            {
                streak++;
                if (streak > longest) longest = streak;
            }
            else streak = 1;
        }

        return longest;
    }
}
