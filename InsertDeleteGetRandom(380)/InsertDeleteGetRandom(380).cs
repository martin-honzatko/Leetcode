public class InsertDeleteGetRandom_380_
{
    public class RandomizedSet
    {
        private Dictionary<int, int> indices = new();
        private List<int> vals = new();
        private Random rnd = new();

        public RandomizedSet() { }

        public bool Insert(int val)
        {
            if (indices.ContainsKey(val)) return false;
            vals.Add(val);
            indices.Add(val, vals.Count - 1);
            return true;
        }

        public bool Remove(int val)
        {
            if (indices.TryGetValue(val, out var idx))
            {
                if (idx < vals.Count - 1) { vals[idx] = vals[^1]; indices[vals[idx]] = idx; }
                indices.Remove(val);
                vals.RemoveAt(vals.Count - 1);
                return true;
            }

            return false;
        }

        public int GetRandom() { var idx = rnd.Next(vals.Count); return vals[idx]; }
    }

    /**
        * Your RandomizedSet object will be instantiated and called as such:
        * RandomizedSet obj = new RandomizedSet();
        * bool param_1 = obj.Insert(val);
        * bool param_2 = obj.Remove(val);
        * int param_3 = obj.GetRandom();
        */
}
