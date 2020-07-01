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

        public void Move(string move)
        {
            foreach (char c in move)
            {
                position = GetCellPosition() + Rotate(c);
            }
        }

        private string GetCellPosition()
        {
            return position.Split(' ')[0] + " " + position.Split(' ')[1] + " ";
        }

        private string Rotate(char ratation)
        {
            var orientation = Enum.Parse(typeof(Direction), position.Split(' ')[2]);
            orientation = (ratation.Equals('R'))
                ? ((int)orientation + 1) % 4
                : ((int)orientation + 3) % 4;
            return ((Direction)orientation).ToString();
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
            _rover.Move(moveCommand);
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
