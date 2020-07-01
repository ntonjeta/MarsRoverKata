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
        private Rover _rover;
        private Plateau _plateau;

        public MarsRover(string dimension)
        {
            var size = dimension.Split(' ');
            _plateau = new Plateau(Int32.Parse(size[0]), Int32.Parse(size[1]));
        }

        public int[,] GetPlateau()
        {
            return _plateau.board;
        }

        public Rover MoveRover(string moveCommand)
        {
            foreach (char move in moveCommand)
            {
                switch (move)
                {
                    case 'M':
                        _rover = _rover.Move( move);
                        break;
                    case 'R':
                    case 'L':
                        _rover = _rover.Rotate(move);
                        break;
                    default:
                        break;
                }
            }

            return _rover;
        }

        public string GetRoverPosition()
        {
            return _rover.position;
        }

        public void PlaceRover(Rover rover)
        {
            _rover = rover;
        }
    }
}
