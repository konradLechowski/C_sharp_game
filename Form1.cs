using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{


    public partial class Form1 : Form
    {

        private Game game;
        private Random random = new Random();
        public Form1()
        {

            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));

            game.NewLevel(random);
            UpdateCharacters();
        }

    
    private void bluePotPic_Click(object sender, EventArgs e)
        {

            if (game.CheckPlayerInventory("niebieska mikstura"))
            {
                game.Equip("niebieska mikstura");
                BorderStyles();
                bluePotPic.BorderStyle = BorderStyle.Fixed3D;
           
            }


        }

        private void redPotPic_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("czerwona mikstura"))
            {
                game.Equip("czerwona mikstura");
                BorderStyles();
                redPotPic.BorderStyle = BorderStyle.Fixed3D;
             
            }

        }

        private void bowPic_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("łuk"))
            {
                game.Equip("łuk");
                BorderStyles();
                bowPic.BorderStyle = BorderStyle.Fixed3D;

            }
            


        }

        private void macePic_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("buława"))
            {
                game.Equip("buława");
                BorderStyles();
                macePic.BorderStyle = BorderStyle.Fixed3D;
            }
           
        }

        private void swordPic_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("miecz"))
            {
                game.Equip("miecz");
                BorderStyles();
                swordPic.BorderStyle = BorderStyle.Fixed3D;

            }
          

        }
        void BorderStyles ()
        {
            swordPic.BorderStyle = BorderStyle.None;
            macePic.BorderStyle = BorderStyle.None;
            bowPic.BorderStyle = BorderStyle.None;
            bluePotPic.BorderStyle = BorderStyle.None;
            redPotPic.BorderStyle = BorderStyle.None;
        }

        private void leftMove_Click(object sender, EventArgs e)
        {
            game.Move(Directions.Left, random);
            UpdateCharacters();

        }

        private void downMove_Click(object sender, EventArgs e)
        {
            game.Move(Directions.Down, random);
            UpdateCharacters();
        }

 

        private void rightMove_Click(object sender, EventArgs e)
        {
            game.Move(Directions.Right, random);
            UpdateCharacters();

        }

        private void upMove_Click(object sender, EventArgs e)
        {
            game.Move(Directions.Up, random);
            UpdateCharacters();

        }

        private void upAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Directions.Up, random);
            UpdateCharacters();

        }

        private void leftAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Directions.Left, random);
            UpdateCharacters();
        }

        private void downAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Directions.Down, random);
            UpdateCharacters();
        }

        private void rightAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Directions.Right, random);
            UpdateCharacters();
        }
    
        public void UpdateCharacters()
        {
            picturePlayer.Location = game.PlayerLocation;
            PlayerHP.Text = game.PlayerHP.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

         
            foreach(Enemy enemy1 in game.Enemies)
            {
                if (enemy1 is Bat)
                {
                    pictureBat.Location = enemy1.Location;
                    batHP.Visible = true;
                    batHP.Text = enemy1.HP.ToString();
                    if (enemy1.HP > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                        pictureBat.Visible = true;
                    }

                }

                if (enemy1 is Ghost)
                {
                    pictureGhost.Location = enemy1.Location;
                    ghostHP.Visible = true;
                    ghostHP.Text = enemy1.HP.ToString();
                    if (enemy1.HP > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                        pictureGhost.Visible = true;
                    }
                }

                if (enemy1 is Ghoul)
                {
                    pictureGhoul.Location = enemy1.Location;
                    ghoulHP.Visible = true;
                    ghoulHP.Text = enemy1.HP.ToString();
                    if (enemy1.HP > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                        pictureGhoul.Visible = true;
                    }
                }

                if (showBat == false)
                {
                    pictureBat.Visible = false;
                    batHP.Visible = false;
                }

                if (showGhoul == false)
                {
                    pictureGhoul.Visible = false;
                    ghoulHP.Visible = false;
                }

                if (showGhost == false)
                {
                    pictureGhost.Visible = false;
                    ghostHP.Visible = false;
                }
            }

            pictureSword.Visible = false;
            pictureBow.Visible = false;
            pictureRedPotion.Visible = false;
            pictureBluePotion.Visible = false;
            pictureMace.Visible = false;
            Control weaponControl = null;
            switch(game.WeaponInRoom.Name)
            {
                case "miecz":
                    weaponControl = pictureSword;
                    break;
                case "łuk":
                    weaponControl = pictureBow;
                    break;
                case "buława":
                    weaponControl = pictureMace;
                    break;
                case "czerwona mikstura":
                    weaponControl = pictureRedPotion;
                    break;
                case "niebieska mikstura":
                    weaponControl = pictureBluePotion;
                    break;
                        
            }
            weaponControl.Visible = true;

            if(game.CheckPlayerInventory("miecz"))
            {
                swordPic.Visible = true;
            }
            if(game.CheckPlayerInventory("łuk"))
            {
                bowPic.Visible = true;
            }
            if(game.CheckPlayerInventory("buława"))
            {
                macePic.Visible = true;
            }
            if(game.CheckPlayerInventory("czerwona mikstura"))
            {
                redPotPic.Visible = true;
            }
            else
            {
                redPotPic.Visible = false;
            }
            if(game.CheckPlayerInventory("niebieska mikstura"))
            {
                bluePotPic.Visible = true;
            }
            else
            {
                bluePotPic.Visible = false;
            }
            weaponControl.Location = game.WeaponInRoom.Location;
            if(game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }
            if(game.PlayerHP<=0)
            {
                MessageBox.Show("zostałeś zabity");
                Application.Exit();
            }
            if(enemiesShown<1)
            {
                MessageBox.Show("pokonałeś przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }

            
            
        }
    }
}
