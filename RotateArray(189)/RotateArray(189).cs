public class RotateArray_189_
{
    public void Rotate(int[] nums, int k)
    {
        if (k == 0 || nums.Length == 1 || nums.Length == k) return;
        int s = 0, p = 0, e = nums[p];
        for (int c = 1; c <= nums.Length; c++)
        {
            p = (p + k) % nums.Length;
            (e, nums[p]) = (nums[p], e);
            if (p == s) { s++; p++; e = nums[p]; }
        }
    }
}
