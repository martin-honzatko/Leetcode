public class ContainsDuplicateII_219_
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> numIndices = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (numIndices.Contains(nums[i])) return true;
            numIndices.Add(nums[i]); 
            if (numIndices.Count > k) numIndices.Remove(nums[i - k]);
        }

        return false;
    }
}
