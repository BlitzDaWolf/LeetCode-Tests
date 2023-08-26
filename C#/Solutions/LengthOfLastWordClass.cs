class LengthOfLastWordClass
{
    public int LengthOfLastWord(string s)
    {
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Last().Length;
    }
}