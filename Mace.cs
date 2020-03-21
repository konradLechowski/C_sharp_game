using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Mace : Weapon
    {
        public Mace(Game game, Point point) : base(game, point)
        {

        }

        public override string Name { get{ return "buława"; } }

        public override void Attack(Directions direction, Random random)
        {
            switch (direction)
            {
                case Directions.Up:
                    if (!DamageEnemy(Directions.Up, 20, 6, random))
                        if (!DamageEnemy(Directions.Right, 20, 6, random))
                            if (!DamageEnemy(Directions.Down, 20, 6, random))
                                DamageEnemy(Directions.Left, 20, 6, random);
                    break;
                case Directions.Left:
                    if (!DamageEnemy(Directions.Left, 20, 6, random))
                        if (!DamageEnemy(Directions.Down, 20, 6, random))
                            if (!DamageEnemy(Directions.Right, 20, 6, random))
                                DamageEnemy(Directions.Up, 20, 6, random);
                    break;
                case Directions.Down:
                    if (!DamageEnemy(Directions.Down, 20, 6, random))
                        if (!DamageEnemy(Directions.Right, 20, 6, random))
                            if (!DamageEnemy(Directions.Up, 20, 6, random))
                                DamageEnemy(Directions.Left, 20, 6, random);
                    break;
                case Directions.Right:
                    if (!DamageEnemy(Directions.Right, 20, 6, random))
                        if (!DamageEnemy(Directions.Up, 20, 6, random))
                            if (!DamageEnemy(Directions.Left, 20, 6, random))
                                DamageEnemy(Directions.Down, 20, 6, random);
                    break;
            }
        }


    }
}
