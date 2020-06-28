using System;

namespace MarsRover
{
    public class Rover
    {
        public string initialPosition { get; set; }
        public int[,] plateau { get; set; }

        public Rover(string dimension)
        {
            var size = dimension.Split(' ');
            var rows = Int32.Parse(size[0]);
            var cols = Int32.Parse(size[1]);

            plateau = new int[rows, cols];
        }

        public void moves(string v)
        {
            throw new NotImplementedException();
        }

        public double getPosition()
        {
            throw new NotImplementedException();
        }
    }
}
