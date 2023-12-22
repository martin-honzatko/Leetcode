public class JumpGame_55_
{
    public bool CanJump(int[] nums)
    {
        int power = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            power--;
            power = Math.Max(power, nums[i]);
            if ((power == 0) && (i != nums.Length - 1)) return false;
        }
        return true;
    }
}
