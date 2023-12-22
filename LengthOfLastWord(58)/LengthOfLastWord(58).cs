public class LengthOfLastWord_58_
{
    public int LengthOfLastWord(string s)
    {
        string[] subs = s.Split(' ');
        int output = subs[^1].Length;

        for (int i = 2; output == 0; i++) if (output == 0) output = subs[^i].Length; 
        return output;
    }
}
