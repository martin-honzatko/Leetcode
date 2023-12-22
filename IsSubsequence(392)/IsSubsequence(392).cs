public class IsSubsequence_392_
{
    public bool IsSubsequence(string s, string t)
    {
        if (s == "") return true;
        int index = 0;
        for (int i = 0; i < t.Length && index < s.Length; i++) if (t[i] == s[index]) ++index;
        return index == s.Length;
    }
}
