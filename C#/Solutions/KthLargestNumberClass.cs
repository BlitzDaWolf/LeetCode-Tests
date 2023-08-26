class KthLargestNumberClass
{
    public string KthLargestNumber(string[] nums, int k)
    {
        int index = nums.Length - k;
        Console.WriteLine("Index: " + index);
        var v = nums.Select(y => (y, y.Select((x, i) => ((int)x) * (i ^ 10 + 1)).Sum()))
            .OrderBy(x => x.Item2)
            // .Select(x => x.Item2)
            .ToList();
        Console.WriteLine("Sorted: " + string.Join(", ", v.Select(x => x.y + ":" + x.Item2)));
        return "";
    }
}