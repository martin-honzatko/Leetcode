public class _3Sum_15_
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);
        for (int s = 0; s < nums.Length - 2; s++)
        {
            int find = (-1)*nums[s], l = s + 1, r = nums.Length - 1;
            while (l < r)
            {
                int current = nums[l] + nums[r];
                if (current > find) r--;
                else if (current < find) l++;
                else
                {
                    int left = nums[l], right = nums[r];
                    res.Add(new List<int>() { nums[s], left, right });
                    if (left == right) break;

                    while ((l < r) && (nums[l] == left)) l++;
                    while ((l < r) && (nums[r] == right)) r--;
                }
            }

            while ((s < nums.Length - 2) && (nums[s] == nums[s + 1])) s++;
        }

        return res;
    }
}
