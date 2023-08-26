class ReverseWordsClass
{
    public string ReverseWords(string s)
    {
        return string.Join(' ', s.Split(' ').Select(x => string.Concat(x.Reverse())));
    }
}