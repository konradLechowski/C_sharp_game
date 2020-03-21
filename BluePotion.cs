using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class BluePotion : Weapon, IPotion
    {
       public BluePotion(Game game, Point location) : base(game,location)
        {

        }

        
        public override string Name { get { return "niebieska mikstura"; } }

        public bool Used { get { return true; } }

        public override void Attack(Directions direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            
            
        }

    }
}
