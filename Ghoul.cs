using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point locatoion) : base(game,locatoion,10)
        {

        }

        public override void Move(Random random)
        {
            
            while(!Dead)
            {
                if (random.Next(1, 3) == 1)
                {

                }
                else
                {
                   location = Move(this.FindPlayerDirection(game.PlayerLocation), game.Boundries);
                }
                if(NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
                return;
            }
        }
    }
}
