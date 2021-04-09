using System;
using System.Linq;

namespace LightsOut
{
    public class Game
    {
        /// <summary>
        /// The max number of rows on the board.
        /// </summary>
        public const int MaxRows = 5;

        /// <summary>
        /// The max number of columns on the board.
        /// </summary>
        public const int MaxColumns = 5;

        /// <summary>
        /// Gets or sets the game board cells.
        /// </summary>
        public Cell[,] Cells { get; set; }

        /// <summary>
        /// Gets whether the player has won.
        /// </summary>
        public bool HasWon
        {
            get => Cells.Cast<Cell>().All(cell => cell.IsLit);  
        }

        private Random random = new Random();

        public Game()
        {
            Cells = new Cell[MaxRows, MaxColumns];
        }

        /// <summary>
        /// Flip the cell at the given row and column.
        /// </summary>
        /// <param name="row">The row of the cell.</param>
        /// <param name="column">The column of the cell.</param>
        public void Flip(int row, int column)
        {
            if (row + 1 < MaxRows)
            {
                Cells[row + 1, column].Flip();
            }

            if (row - 1 >= 0)
            {
                Cells[row - 1, column].Flip();
            }

            if (column + 1 < MaxColumns)
            {
                Cells[row, column + 1].Flip();
            }

            if (column - 1 >= 0)
            {
                Cells[row, column - 1].Flip();
            }
        }

        /// <summary>
        /// Creates the game board state.
        /// </summary>
        public void CreateBoard()
        {
            for (int row = 0; row < MaxRows; row++ )
            {
                for (int column = 0; column < MaxColumns; column++)
                {
                    var randomNumber = random.Next(0, 10);
                    Cells[row, column] = new Cell(row, column, randomNumber > 3);
                }
            }
        }
    }
}
