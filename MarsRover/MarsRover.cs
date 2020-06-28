using System;

namespace MarsRover
{
    public class Rover
    {
        public string initialPosition { get; set; }
        public int[,] plateau { get; set; }

        public Rover(string dimension)
        {
            plateau = new int[5, 5]{
                { 0,0,0,0,0},
                { 0,0,0,0,0},
                { 0,0,0,0,0},
                { 0,0,0,0,0},
                { 0,0,0,0,0}
            };
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
