public class WordPattern_290_
{
    public bool WordPattern(string pattern, string s)
    {
        string[] splitS = s.Split(" ");
        if (pattern.Length != splitS.Length) return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            int pIndex = pattern.IndexOf(pattern[i]), sIndex = Array.IndexOf(splitS, splitS[i]);
            if (pIndex != sIndex)  return false;
        }
        return true;
    }
}
