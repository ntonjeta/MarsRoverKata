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

    public class RoverControl
    {
        private Rover _rover;
        private Plateau _plateau;

        public RoverControl(string dimension)
        {
            var size = dimension.Split(' ');
            _plateau = new Plateau(Int32.Parse(size[0]), Int32.Parse(size[1]));
        }

        public int[,] GetPlateau()
        {
            return _plateau.board;
        }

        public Rover MoveRover(string commandList)
        {
            foreach (char move in commandList)
            {
                SendCommand(move);
            }

            return _rover;
        }

        private void SendCommand(char command)
        {
            switch (command)
            {
                case 'M':
                    _rover = _rover.Move(command);
                    break;
                case 'R':
                case 'L':
                    _rover = _rover.Rotate(command);
                    break;
                default:
                    break;
            }
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
