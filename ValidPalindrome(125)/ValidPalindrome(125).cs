using System.Text.RegularExpressions;
public class ValidPalindrome_125_
{
    public bool IsPalindrome(string s)
    {
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        s = rgx.Replace(s.ToLower(), "");
        int l = 0, r = s.Length - 1;

        while (l <= r) { if (s[l] == s[r]) { l++; r--; } else return false; }
        return true;
    }
}
