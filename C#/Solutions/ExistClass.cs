class ExistClass
{
    public bool Exist(char[][] board, string word)
    {
        var r = string.Concat(board.SelectMany(x => x));

        int i = 0;
        while (i < r.Length)
        {
            if (word.Contains(r[i]))
            {
                word = word.Remove(word.IndexOf(r[i]), 1);
                r = r.Remove(i,1);
            }
            else
                i++;
        }

        return string.IsNullOrEmpty(word);
    }
}