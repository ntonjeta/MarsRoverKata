using System;

namespace MarsRover
{
    enum Direction : int
    {
        N = 0,
        E = 1,
        S = 2,
        O = 3
    }

    public class Rover
    {
        private const char Rigth = 'R';
        private const int rowsIndex = 0;
        private const int colsIndex = 1;
        private const int directionIndex = 2;

        public string position { get; set; }

        public Rover(string position)
        {
            this.position = position;
        }

        public Rover Move(char move)
        {
            return new Rover(GetCellPosition() + Rotate(move));
        }

        private string GetCellPosition()
        {
            return position.Split(' ')[rowsIndex] + " " + position.Split(' ')[colsIndex] + " ";
        }

        private string Rotate(char rotation)
        {
            var orientation = Enum.Parse(typeof(Direction), position.Split(' ')[directionIndex]);
            orientation = (rotation.Equals(Rigth))
                ? ((int)orientation + 1) % 4
                : ((int)orientation + 3) % 4;
            return ((Direction)orientation).ToString();
        }
    }
}
