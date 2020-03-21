using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location) : base(game, location)
        {

        }

        public override string Name { get { return "łuk"; } }

        public override void Attack(Directions direction, Random random)
        {
            switch (direction)
            {
                case Directions.Up:
                    DamageEnemy(Directions.Up, 30, 1, random);
                    break;
                case Directions.Left:
                    DamageEnemy(Directions.Left, 10, 1, random);
                    break;
                case Directions.Down:
                    DamageEnemy(Directions.Down, 10, 1, random);
                    break;
                case Directions.Right:
                    DamageEnemy(Directions.Right, 10, 1, random);
                    break;
            }

        }
    }
}
