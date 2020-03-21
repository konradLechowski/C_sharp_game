using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab2
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {

        }

        public override void Move(Random random)
        {
            while(!Dead)
            {
                if(random.Next(1,3)==1)
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
