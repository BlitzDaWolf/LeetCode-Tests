class FindOcurrencesClass
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var v = text.Split(" ");
        List<string> result = new List<string>();
        int j = 0;
        for (int i = 0; i < v.Length; i++)
        {
            if(j == 2)
            {
                result.Add(v[i]);
                j = 0;
            }
            if (j == 1)
            {
                j = v[i] == second ? 2 : 0;
            }
            if (j == 0)
            {
                j = v[i] == first ? 1 : 0;
            }
        }
        return result.ToArray();
    }
}