class LengthOfLongestSubstringClass
{
    public int LengthOfLongestSubstring(string s)
    {
        int best = 0;
        for (int i = 0; i < s.Length; i++)
        {
            string current = "";
            for (int j = i; j < s.Length; j++)
            {
                if (current.Contains(s[j])) break;
                current += s[j];
            }
            best = Math.Max(best, current.Length);
        }
        return best;
    }
}