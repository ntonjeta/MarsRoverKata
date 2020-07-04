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

            switch (rover.Direction())
            {
                case Direction.N:
                    col++;
                    break;
                case Direction.E:
                    row++;
                    break;
                case Direction.S:
                    col--;
                    break;
                case Direction.O:
                    row--;
                    break;
            }
            return new Rover($"{row.ToString()} {col.ToString()} {rover.Direction().ToString()}");
        }
    }
}
