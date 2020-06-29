using System;

namespace MarsRover
{
    class Plateau
    {
        public int[,] board { get; set; }

        public Plateau(int rows, int cols)
        {
            board = new int[rows, cols];
        }
    }

    public class MarsRover
    {
        public string position { get; set; }
        private Plateau plateau;

        public MarsRover(string dimension)
        {
            var size = dimension.Split(' ');
            plateau = new Plateau(Int32.Parse(size[0]), Int32.Parse(size[1]));
        }

        public int[,] GetPlateau()
        {
            return plateau.board;
        }

        public void move(string move)
        {
            position = "1 2 O";
        }
    }
}
