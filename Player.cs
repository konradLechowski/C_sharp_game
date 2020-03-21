using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Player : Mover
    {
        private Weapon equippedWeapon;

        public int HP { get; private set; }

        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }

        public Player( Game game, Point location) : base(game, location)
        {
            HP = 10; 
        }
        
        public void Hit (int maxDamage, Random random)
        {
            HP -= random.Next(1, maxDamage); 
        }

        public void IncreaseHealth(int health, Random random)
        {
            HP += random.Next(1, health);
        }

        public void Equip (string weaponName)
        {
            foreach(Weapon weapon in  inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move (Directions direction)
        {
            base.location = Move(direction, game.Boundries);
            if(!game.WeaponInRoom.PickedUp)
            {
                if( this.Nearby(game.WeaponInRoom.Location, 10))
                {
                    game.WeaponInRoom.PickUpWeapon();   
                    inventory.Add(game.WeaponInRoom);
                    if (game.WeaponInRoom.Name == "miecz") 
                    {
                        this.Equip("miecz");
                        
                    }
                   
                }
                
            }
        }

        public void Attack(Directions direction, Random random )
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    inventory.Remove(equippedWeapon);
                    
                }
                
                
            }
        }

        
    }
}
