public class TwoSum_1_
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i++)
        {
            int num2 = target - nums[i];
            if (map.ContainsKey(num2)) return [i, map[num2]]; 
            if (!map.ContainsKey(nums[i])) map.Add(nums[i], i);
        }

        return null;
    }
}
