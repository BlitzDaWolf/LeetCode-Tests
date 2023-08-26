class LongestCommonPrefixClass
{
    public string LongestCommonPrefix(string[] strs)
    {
        var smalestWord = strs.OrderBy(x => x.Length).First();
        string best = "";

        for (int i = 1; i < smalestWord.Length; i++)
        {
            var sub = smalestWord.Substring(0, i+1);
            if (strs.Select(x => x.StartsWith(sub)).Contains(false)) break;
            best = sub;
        }

        return best;
    }
}