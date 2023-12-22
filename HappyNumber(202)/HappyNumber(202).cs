public class HappyNumber_202_
{
    public bool IsHappy(int n)
    {
        if (n == 1) return true;
        HashSet<int> num = [];
        int sum = 0, p = 0;
        while (n > 1)
        {
            while (n != 0) { p = n % 10; sum += (p * p); n /= 10; }
            n = sum;
            if (sum == 1) return true;
            if (!num.Add(sum)) return false;
            sum = 0;
        }
        return (sum == 1);
    }
}
