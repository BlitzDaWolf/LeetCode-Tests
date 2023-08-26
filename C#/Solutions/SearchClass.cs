class SearchClass
{
    public int Search(int[] nums, int target)
    {
        if (!nums.Contains(target)) return -1;
        return nums.ToList().IndexOf(target);
    }
}