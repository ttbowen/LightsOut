namespace LightsOut
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsLit { get; set; }

        public Cell(int row, int column, bool isLit)
        {
            Row = row;
            Column = column;
            IsLit = isLit;
        }

        public void Flip()
        {
            IsLit = !IsLit;
        }
    }
}
