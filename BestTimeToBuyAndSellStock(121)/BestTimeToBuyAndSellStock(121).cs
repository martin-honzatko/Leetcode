public class BestTimeToBuyAndSellStock_121_
{
    public int MaxProfit(int[] prices)
    {
        int min = prices[0], max = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min) min = prices[i];
            if ((prices[i] - min) > max) max = prices[i] - min;
        }

        return max;
    }
}
