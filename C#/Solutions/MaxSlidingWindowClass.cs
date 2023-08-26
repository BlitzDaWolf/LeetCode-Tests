class MaxSlidingWindowClass
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0 || k == 0) return new int[0];
        int[] result = new int[nums.Length - k + 1];

        int ri = 0;
        LinkedList<int> q = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            while (q.Count > 0 && q.First.Value < i - k + 1) q.RemoveFirst();
            while (q.Count > 0 && nums[q.Last.Value] <= nums[i]) q.RemoveLast();

            q.AddLast(i);
            if (i >= k - 1) result[ri++] = nums[q.First.Value];
        }

        return result;
    }
}