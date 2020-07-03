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
        private const int orientationIndex = 2;

        private string position;

        public Rover(string position)
        {
            this.position = position;
        }

        public Rover Rotate(char rotation)
        {
            var orientation = Enum.Parse(typeof(Direction), Orientation());
            orientation = (rotation.Equals(Rigth))
                ? ((int)orientation + 1) % 4
                : ((int)orientation + 3) % 4;
            return new Rover($"{Row()} {Col()} { ((Direction)orientation).ToString() }");
        }

        public string Row()
        {
            return position.Split(' ')[rowsIndex];
        }

        public string Col()
        {
            return position.Split(' ')[colsIndex];
        }

        public string Orientation()
        {
            return position.Split(' ')[orientationIndex];
        }

        private string GetCellPosition()
        {
            return $"{Row()} {Col()} ";
        }
    }
}
