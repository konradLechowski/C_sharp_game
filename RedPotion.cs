using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class RedPotion : Weapon, IPotion
    {

        public RedPotion(Game game,Point location) : base(game,location)
        {

        }
        public bool Used { get { return true; } }
        public override string Name { get { return "czerwona mikstura"; } }

        public override void Attack(Directions direction, Random random)
        {
            game.IncreasePlayerHealth(10, random);
        }
            
        
    }
}
