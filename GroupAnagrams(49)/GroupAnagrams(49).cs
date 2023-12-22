public class GroupAnagrams_49_
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> dict = [];
        for (int i = 0; i < strs.Length; i++)
        {
            char[] arr = strs[i].ToCharArray();
            Array.Sort(arr);
            String sorted = new(arr);

            if (!dict.ContainsKey(sorted)) dict.Add(sorted, new List<String>() { strs[i] }); 
            else dict[sorted].Add(strs[i]);
        }

        return dict.Values.ToList();
    }
}
