using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab2
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base (game,location)
        {

        }
        public override string Name { get { return "miecz"; } }

        public override void Attack(Directions direction, Random random)
        {
            switch (direction)
            {
                case Directions.Up:
                    if (!DamageEnemy(Directions.Up, 10, 3, random))
                        if (!DamageEnemy(Directions.Right, 10, 3, random))
                            DamageEnemy(Directions.Left, 10, 3, random);
                    break;
                case Directions.Left:
                    if (!DamageEnemy(Directions.Left, 10, 3, random))
                        if (!DamageEnemy(Directions.Up, 10, 3, random))
                            DamageEnemy(Directions.Down, 10, 3, random);
                    break;
                case Directions.Down:
                    if (!DamageEnemy(Directions.Down, 10, 3, random))
                        if (!DamageEnemy(Directions.Left, 10, 3, random))
                            DamageEnemy(Directions.Right, 10, 3, random);
                    break;
                case Directions.Right:
                    if (!DamageEnemy(Directions.Right, 10, 3, random))
                        if (!DamageEnemy(Directions.Down, 10, 3, random))
                            DamageEnemy(Directions.Up, 10, 3, random);
                    break;
            }



        }
    }
}
