class UncommonFromSentencesClass
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        string[] total = (s1 + " " + s2).Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return total.Where(x => total.Where(y => y == x).Count() == 1).ToArray();
    }
}