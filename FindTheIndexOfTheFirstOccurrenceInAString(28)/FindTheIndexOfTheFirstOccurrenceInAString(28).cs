public class FindTheIndexOfTheFirstOccurrenceInAString_28_
{
    public int StrStr(string haystack, string needle)
    {
        int res = -1, matchLoc = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[matchLoc])
            {
                matchLoc++;
                if (matchLoc == needle.Length) { res = i - matchLoc + 1; break; }
            }
            else { i -= matchLoc; matchLoc = 0; }
        }
        return res;
    }
}
