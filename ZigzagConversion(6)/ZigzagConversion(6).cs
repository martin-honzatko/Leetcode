using System.Text;

public class ZigzagConversion_6_
{
    public string Convert(string s, int numRows)
    {
        int ColumnsNeeded(string s, int rows)
        {
            int chars = s.Length, columns = 0;
            while (chars > 0)
            {
                chars -= rows; columns++;
                if (chars <= 0) return columns;

                for (int i = 0; i < (rows - 2); ++i)
                {
                    columns++; chars--;
                    if (chars <= 0) return columns;
                }
            }

            return columns;
        }

        if (numRows == 1) return s;

        char[][] grid = new char[numRows][];
        int columns = ColumnsNeeded(s, numRows);
        for (int i = 0; i < numRows; ++i) grid[i] = new char[columns]; 

        bool goingUp = false, goingDown = true;
        int x = 0, y = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            grid[x][y] = s[i];
            if (x == numRows - 1)
            {
                goingUp = true;
                goingDown = false;
            }

            if (x == 0 && !(x == 0 && y == 0))
            {
                goingUp = false;
                goingDown = true;
            }

            if (goingDown) x++;
            if (goingUp) { x--; y++; }
        }

        StringBuilder res = new();
        for (int i = 0; i < grid.Length; ++i)
        {
            for (int j = 0; j < grid[i].Length; ++j)
            {
                if (grid[i][j] != '\0') res.Append(grid[i][j]); 
            }
        }

        return res.ToString();
    }
}
