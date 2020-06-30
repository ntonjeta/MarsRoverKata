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

    class Rover
    {
        public string position { get; set; }

        public void move(string move)
        {
            var rows = position.Split(' ')[0];
            var cols = position.Split(' ')[1];
            var actualDirection = position.Split(' ')[2];
            string cellPosition = rows + " " + cols + " ";

            switch (move)
            {
                case "L":
                    position = cellPosition + "O";
                    break;
                case "R":
                    position = cellPosition + "E";
                    break;
            }
        }
    }

    public class MarsRover
    {
        private Rover _rover;
        private Plateau _plateau;

        public MarsRover(string dimension)
        {
            var size = dimension.Split(' ');
            _plateau = new Plateau(Int32.Parse(size[0]), Int32.Parse(size[1]));
            _rover = new Rover();
        }

        public int[,] GetPlateau()
        {
            return _plateau.board;
        }

        public void MoveRover(string moveCommand)
        {
            _rover.move(moveCommand);
        }

        public string GetRoverPosition()
        {
            return _rover.position;
        }

        public void SetRoverPosition(string position)
        {
            _rover.position = position;
        }
    }
}
