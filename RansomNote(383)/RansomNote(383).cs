public class RansomNote_383_
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> list = new(magazine);
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!list.Remove(ransomNote[i])) return false; 
        }
        return true;
    }
}
