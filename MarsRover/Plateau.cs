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
            var row = Int32.Parse(rover.Row());
            var col = Int32.Parse(rover.Col());
            var or = rover.Orientation();
            if (or.ToString() == "N")
                col++;
            else
                row--;
            return new Rover($"{row.ToString()} {col.ToString()} {or.ToString()}");
        }
    }
}
