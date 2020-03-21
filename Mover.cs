using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover( Game game, Point location )
        {
            this.game = game;
            this.location = location;
        }
        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Nearby(locationToCheck, this.Location, distance))
                return true;
            else
                return false;              

        }
        public bool Nearby(Point locationToCheck, Point target, int distance )
        {
            if (Math.Abs(target.X - locationToCheck.X) <= distance && Math.Abs(target.Y - locationToCheck.Y) <= distance)
                return true;
            else
                return false;

        }
        public Point Move(Directions direction, Rectangle boundaries)
        {
            Point newLocation = Move(direction,this.Location,boundaries);
            
            return newLocation;
        }
        public Point Move(Directions direction, Point target, Rectangle boundaries)
        {
            Point newLocation = target;
            switch (direction)
            {
                case Directions.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Directions.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Directions.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Directions.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default:
                    break;
            }
            return newLocation;
        }
    }
}
