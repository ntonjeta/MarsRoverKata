using System;

namespace MarsRover
{
    public class Plateau
    {
        public int[,] board { get; set; }

        public Plateau(int rows, int cols)
        {
            board = new int[rows, cols];
        }

        public Rover Move(Rover rover, char command)
        {
            var row = rover.RowIndex();
            var col = rover.ColIndex();
            var or = rover.Direction();
            if (or.ToString() == "N")
                col++;
            else if (or.ToString() == "E")
                row++;
            else
                row--;
            return new Rover($"{row.ToString()} {col.ToString()} {or.ToString()}");
        }
    }
}
