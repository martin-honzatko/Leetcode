﻿public class TwoSumII_167_
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int min = 0, max = numbers.Length - 1;
        while ((numbers[min] + numbers[max]) != target)
        {
            if ((numbers[min] + numbers[max]) > target) max--;
            else min++;
        }
        return [min + 1, max + 1];
    }
}
