using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab2
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;

        public int HP{ get; private set; }
        public bool Dead { get
            {
                if (HP <= 0)
                    return true;
                else
                    return false;
            } }
        public Enemy(Game game, Point location, int HP ) : base(game, location)
        {
            this.HP = HP;
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            HP -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }
        protected Directions FindPlayerDirection(Point playerLocation)
        {
            Directions directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Directions.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Directions.Left;
            else if (playerLocation.Y > location.Y + 10)
                directionToMove = Directions.Down;
            else 
                directionToMove = Directions.Up;
            return directionToMove;
        }
    }
}
