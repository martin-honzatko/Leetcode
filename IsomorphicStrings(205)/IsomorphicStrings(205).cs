public class IsomorphicStrings_205_
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> dS = [], dT = [];
        for (var i = 0; i < s.Length; i++)
        {
            dS.TryAdd(s[i], t[i]);
            dT.TryAdd(t[i], s[i]);
        }
        for (var i = 0; i < s.Length; i++)
        {
            if ((dS[s[i]] != t[i]) || (dT[t[i]] != s[i])) return false;
        }
        return true;
    }
}
