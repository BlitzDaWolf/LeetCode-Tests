class DivideArrayClass
{
    public bool DivideArray(int[] nums)
    {
        if(nums.Length %2!=0) return false;
        List<int> data = nums.ToList();
        while (data.Count > 0)
        {
            var c = data.First();
            data.RemoveAt(0);
            int inx = data.IndexOf(c);
            if (inx == -1) return false;
            data.RemoveAt(inx);
        }
        return true;
    }
}