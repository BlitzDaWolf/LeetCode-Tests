class ProductExceptSelfClass
{
    public int[] ProductExceptSelf(int[] nums)
    {
        GC.Collect();
        int[] res = new int[nums.Length];
        for (int i = 0, prev = 1; i < nums.Length; i++)
        {
            res[i] = prev;
            prev = nums[i] * prev;
        }

        for (int i = nums.Length - 1, prev = 1; i >= 0; i--)
        {
            res[i] = res[i] * prev;
            prev = nums[i] * prev;
        }

        return res;
    }
}