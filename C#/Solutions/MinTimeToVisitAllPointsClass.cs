class MinTimeToVisitAllPointsClass
{
    public int MinTimeToVisitAllPoints(int[][] points)
    {
        List<int[]> Path = new List<int[]>();
        int[] target = points[1];
        int[] current = points[0];
        Path.Add(current);

        for (int i = 0; i < points.Length - 1; i++)
        {
            target = points[i+1];
            current = points[i];
            Console.WriteLine(string.Join(",", current));

            int[] offset = new int[] { target[0] - current[0], target[1] - current[1] };
            while (offset.Sum() != 0)
            {
                current[0] += Math.Max(-1, Math.Min(1, offset[0]));
                current[1] += Math.Max(-1, Math.Min(1, offset[1]));

                Path.Add(new int[] { current[0], current[1] });
                Console.WriteLine(string.Join(",", current));
                offset = new int[] { target[0] - current[0], target[1] - current[1] };
            }
        }

        Console.WriteLine(string.Join(",",
            Path.Select(x => "[" +string.Join(",", x) + "]")));

        return Path.Count - 1;
    }
}