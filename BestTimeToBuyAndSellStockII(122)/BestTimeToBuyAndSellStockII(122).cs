public class BestTimeToBuyAndSellStockII_122_
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length < 2) { return 0; }
        int min = prices[0], max = prices[0], sum = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > max)
            {
                max = prices[i];
                continue;
            }
            if (prices[i] < max)
            {
                sum += (max - min);
                min = max = prices[i];
            }
        }
        sum += (max - min);

        return sum;
    }
}
