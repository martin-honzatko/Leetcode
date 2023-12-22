public class TrappingRainWater_42_
{
    public int Trap(int[] height)
    {
        int n = height.Length, maxI = 0, res = 0, max = height[0];
        for (int i = 1; i < n; i++) if (height[maxI] < height[i]) maxI = i;
        for (int i = 0; i <= maxI; i++)
        {
            res += Math.Max(0, max - height[i]);
            if (height[i] > max) max = height[i];
        }

        max = height[n - 1];
        for (int i = n - 1; i >= maxI; i--)
        {
            res += Math.Max(0, max - height[i]);
            if (height[i] > max) max = height[i];
        }

        return res;
    }
}
