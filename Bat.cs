using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace lab2
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location ) : base(game, location, 6)
        {

        }
        public override void Move(Random random)
        {
            while(!Dead)
            {
                if(random.Next(1, 10)<=5)
                {
                    
                    location = Move(this.FindPlayerDirection(game.PlayerLocation), game.Boundries);
                                        
                }
                else
                {
                  
                    location = Move((Directions)random.Next(1, 4), game.Boundries);
                }
                if(this.NearPlayer())
                {
                    game.HitPlayer(2, random);
                }
                return;
            }
            
            
        }
    }
}
