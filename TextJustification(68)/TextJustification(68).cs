using System.Text;

public class TextJustification_68_
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> res = [];
        int startIndex = 0;

        while (startIndex < words.Length)
        {
            int endIndex = startIndex, lineLength = 0;

            while ((endIndex < words.Length) && ((lineLength + words[endIndex].Length + (endIndex - startIndex)) <= maxWidth))
            {
                lineLength += words[endIndex].Length;
                endIndex++;
            }

            int totalSpaces = maxWidth - lineLength, totalGaps = endIndex - startIndex - 1;
            StringBuilder lineBuilder = new();
            if (endIndex == words.Length || totalGaps == 0)
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    lineBuilder.Append(words[i]);
                    if (i < endIndex - 1) lineBuilder.Append(' ');
                }
                while (lineBuilder.Length < maxWidth) lineBuilder.Append(' ');
            }
            else
            {
                int spacesPerGap = totalSpaces/totalGaps, extraSpaces = totalSpaces%totalGaps;
                for (int i = startIndex; i < endIndex; i++)
                {
                    lineBuilder.Append(words[i]);
                    if (i < endIndex - 1)
                    {
                        int spacesToAdd = spacesPerGap + (i - startIndex < extraSpaces ? 1 : 0);
                        lineBuilder.Append(' ', spacesToAdd);
                    }
                }
            }

            res.Add(lineBuilder.ToString());
            startIndex = endIndex;
        }

        return res;
    }
}
