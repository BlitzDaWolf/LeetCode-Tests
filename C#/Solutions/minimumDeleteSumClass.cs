class minimumDeleteSumClass
{
    int minimumDeleteSum(string s1, string s2)
    {
        return (s1 + s2).Distinct().Select(x => (int)x).Sum();
    }
}