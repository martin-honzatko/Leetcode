public class ValidAnagram_242_
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Span<int> usedS = stackalloc int[26], usedT = stackalloc int[26];

        for (int i = 0; i < s.Length; i++)
        {
            usedS[s[i] - 97]++; 
            usedT[t[i] - 97]++;
        }

        return usedS.SequenceEqual(usedT);
    }
}
