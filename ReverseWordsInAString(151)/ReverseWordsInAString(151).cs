﻿internal class ReverseWordsInAString_151_
{
    internal string ReverseWords(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
