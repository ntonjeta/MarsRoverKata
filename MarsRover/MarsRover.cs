using System;

namespace MarsRover
{
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

        public void MoveRover(string commandList)
        {
            foreach (char move in commandList)
            {
                SendCommand(move);
            }
        }

        private void SendCommand(char command)
        {
            switch (command)
            {
                case 'M':
                    _rover = _plateau.Move(_rover, command);
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
            return $"{_rover.Row()} {_rover.Col()} {_rover.Orientation()}";
        }

        public void PlaceRover(Rover rover)
        {
            _rover = rover;
        }
    }
}
