using System;

namespace MarsRover
{
    public enum Direction : int
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
        private const int orientationIndex = 2;
        private const int DirectionCardinality = 4;
        private string position;

        public Rover(string position)
        {
            this.position = position;
        }

        public Rover Rotate(char rotation)
        {
            var newOrientation = (rotation.Equals(Rigth))
                ? RotateToRigth()
                : RotateToLeft();

            return new Rover($"{Row()} {Col()} { ((Direction)newOrientation).ToString() }");
        }

        private int RotateToLeft()
        {
            return ((int)Direction() + 3) % DirectionCardinality;
        }

        private int RotateToRigth()
        {
            return ((int)Direction() + 1) % DirectionCardinality;
        }

        public string Row()
        {
            return position.Split(' ')[rowsIndex];
        }

        public string Col()
        {
            return position.Split(' ')[colsIndex];
        }

        public int RowIndex()
        {
            return Int32.Parse(this.Row());
        }

        public int ColIndex()
        {
            return Int32.Parse(this.Col());
        }

        public Direction Direction()
        {
            return (Direction)Enum.Parse(typeof(Direction), position.Split(' ')[orientationIndex]);
        }

        private string GetCellPosition()
        {
            return $"{Row()} {Col()} ";
        }
    }
}
