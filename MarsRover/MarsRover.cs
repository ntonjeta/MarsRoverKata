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

        internal Rover Move(Rover rover, char command)
        {
            var row = Int32.Parse(rover.position.Split(' ')[0]);
            var col = Int32.Parse(rover.position.Split(' ')[1]);
            var or = rover.position.Split(' ')[2];
            if (or.ToString() == "N")
                col++;
            else 
                row--;
            return new Rover($"{row.ToString()} {col.ToString()} {or.ToString()}");
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
            return _rover.position;
        }

        public void PlaceRover(Rover rover)
        {
            _rover = rover;
        }
    }
}
