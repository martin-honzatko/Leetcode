internal class ContainerWithMostWater_11_
{
    int MaxArea(int[] height)
    {
        int j = 0, k = height.Length - 1;
        List<int> AreaList = new List<int>();
        while (j < k)
        {
            int area = Math.Min(height[j], height[k]) * (k - j);
            AreaList.Add(area);
            if (height[j] < height[k]) j++;
            else k--;
        }

        return AreaList.Max();
    }
}
