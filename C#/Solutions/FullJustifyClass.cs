class FullJustifyClass
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> justifiedLines = new List<string>();
        string currentLine = "";

        foreach (string word in words)
        {
            if ((currentLine + word).Length <= maxWidth)
            {
                currentLine += word + " ";
            }
            else
            {
                justifiedLines.Add(JustifyLine(currentLine.Trim(), maxWidth));
                currentLine = word + " ";
            }
        }

        // Justify the last line
        justifiedLines.Add(JustifyLine(currentLine.Trim(), maxWidth));

        return justifiedLines;
    }
    
    string JustifyLine(string line, int lineLength)
    {
        string[] words = line.Split(' ');
        int spaceCount = Math.Max(words.Length - 1,1);
        int totalSpacesNeeded = Math.Max(words.Length - 1, 1);

        int baseSpaces = totalSpacesNeeded / spaceCount;
        int extraSpaces = totalSpacesNeeded % spaceCount;

        string justifiedLine = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            int spacesToAdd = baseSpaces + (i <= extraSpaces ? 1 : 0);
            justifiedLine += new string(' ', spacesToAdd) + words[i];
        }

        return justifiedLine;
    }
}