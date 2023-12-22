public class RomanToInteger_13_
{
    public int RomanToInt(string s)
    {
        int RomanNumerals(char c)
        {
            switch (c)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
            };
            return 0;
        }

        char[]? chars = s.ToCharArray();
        int res = 0;
        for (var i = 0; i < chars.Length - 1; i++)
        {
            int currentValue = RomanNumerals(chars[i]);
            res += (RomanNumerals(chars[i + 1]) > currentValue ? -1 : 1) * currentValue;
        }

        return (res + RomanNumerals(chars[chars.Length - 1]));
    }
}
