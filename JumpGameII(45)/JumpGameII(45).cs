public class JumpGameII_45_
{
    public int Jump(int[] nums)
    {
        int jumps = 0, end = 0, current = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            current = Math.Max(current, i + nums[i]);
            if (i == end) { jumps++; end = current; }
        }
        return jumps;
    }
}
