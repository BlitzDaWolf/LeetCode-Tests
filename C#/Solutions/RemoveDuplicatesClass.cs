class RemoveDuplicatesClass
{
    public int RemoveDuplicates(int[] nums)
    {
        nums = nums.Distinct().ToArray();
        return nums.Length;
    }
}