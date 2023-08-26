class RepeatedSubstringPatternClass
{
    public bool RepeatedSubstringPattern(string s)
    {
        Enumerable.Range(0, s.Length / 2).Select(x => x % 2 == 0 ? s.Substring(0, x)=="" : false);
        if (s.Length % 2 == 1) return false;
        var sub_str = s.Substring(0, s.Length / 2);
        s = s.Remove(0, s.Length / 2);
        var res = (s.Contains(sub_str));
        return res;
    }
}