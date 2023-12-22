public class ProductOfArrayExceptSelf_238_
{
    public int[] ProductExceptSelf(int[] nums)
    {
        Span<int> input = nums.AsSpan();
        int length = nums.Length, lastIndex = length - 1;
        Span<int> res = stackalloc int[length];
        res.Fill(1);

        for (int i = 0, left = 1, right = 1; i < length; i++)
        {
            res[i] *= left;
            left *= input[i];

            res[lastIndex - i] *= right;
            right *= input[lastIndex - i];
        }

        res.CopyTo(input);
        return nums;
    }
}
