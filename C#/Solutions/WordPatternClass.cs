class WordPatternClass
{
    public bool WordPattern(string pattern, string s)
    {
        var v = s.Split(' ');
        if(v.Length != pattern.Length) return false;
        Dictionary<char, string> d = new Dictionary<char, string>();
        for (int i = 0; i < v.Length; i++)
        {
            if (!d.ContainsKey(pattern[i]))
            {
                if (d.ContainsValue(v[i])) return false;
                d.Add(pattern[i], v[i]);
            }
            else
            {
                if (v[i] != d[pattern[i]]) return false;
            }
        }
        return true;
    }
}