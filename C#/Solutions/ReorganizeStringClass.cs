class ReorganizeStringClass
{
    public string ReorganizeString(string s)
    {
        var grouped = s.GroupBy(c => c)
            .OrderByDescending(c => c.Count());
        if (grouped.First().Count() > (s.Length + 1) / 2) return "";

        var res = new char[s.Length];
        int idx = 0;

        foreach (var c in grouped.SelectMany(c => c))
        {
            res[idx] = c;
            idx += 2;
            if (idx >= s.Length)
                idx = 1;
        }

        return new string(res);
    }
}