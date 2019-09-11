using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FireGameLovepreet
{

    public partial class GameArea : Form
    {
        int Shoot = 0;
        int Match = 0, countShoot = 0,countShootAwayFire=0,countShootAway=0;
        
        Rndm instance_Object = new Rndm();

        //contructor of the class that is used to disable the button of the game and then enable the button one by one 
        public GameArea()
        {
            InitializeComponent();

            Match = instance_Object.fireMatch();

            LoadButton.Enabled = false;
            ShootButton.Enabled = false;
            ShootAwayButton.Enabled = false;
            PlayAgainButton.Enabled = false;

        }

        private void ShootAwayButton_Click(object sender, EventArgs e)
        {
            //this code is used to shoot away tast to be performed 
            pistol.ImageLocation = "data/img3.jpg";
            countShootAwayFire++;
            countShootAway++;
            //match the trigger with the fire no to find the winner or looser
            if (countShootAwayFire == Match)
            {
                pistol.ImageLocation = "";
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("data/sound.wav");
                player.Play();

                MessageBox.Show("Hurry You won the Game ");
                ShootAwayButton.Enabled = false;
                StartButton.Enabled = false;
            }
            else {
               
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("data/Empty.wav");
                player.Play();
                if (countShootAway==6) {
                    MessageBox.Show("this is your last chance to play");
                    Match = instance_Object.fireMatch();
                }
                if (countShootAway==12) {
                    MessageBox.Show("Sorry this Game is Over Now CLick on Play Again to fire");
                    ShootAwayButton.Enabled = false;
                    StartButton.Enabled =false;
                }
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            //this code is used to restart the game once again  and reset all the variable 
            StartButton.Enabled = true;
            LoadButton.Enabled = false;
            ShootButton.Enabled = false;
            ShootAwayButton.Enabled = false;
            PlayAgainButton.Enabled = false;
            Shoot = 0;
            Match = instance_Object.fireMatch();
            countShoot = 0;
            countShootAwayFire = 0;
            countShootAway = 0;

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //this is the starting button of the game to start the game 
            pistol.ImageLocation = "data/img1.jpg";

            LoadButton.Enabled = true;
            ShootButton.Enabled = false;
            ShootAwayButton.Enabled = false;
            PlayAgainButton.Enabled = false;

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //this  is the loading button to load the bullet in the fire 
            pistol.ImageLocation = "data/img2.jpg";
            LoadButton.Enabled = true;
            ShootButton.Enabled = true;
            ShootAwayButton.Enabled = true;
            PlayAgainButton.Enabled = true;
        }

        private void ShootButton_Click(object sender, EventArgs e)
        {
            //this code is used to count the no of fire if the no of fire is match with the random no then  the random no then print the message 
            pistol.ImageLocation = "data/img3.jpg";
            Shoot++;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("data/sound.wav");
            player.Play();
            // this block is used to check fire is matched with the random no or not if it is matched then it display the congrats mesage 
            if (Shoot==Match) {
                pistol.ImageLocation = "";
                MessageBox.Show("Hurry you won the game in "+ Shoot +"th Fire");
                Shoot = 0;
                ShootButton.Enabled = false;
                StartButton.Enabled = false;
            }
            // this block is used when 6 fire is trigger then the message will display the your first chance is over
           else if (Shoot==6 && countShoot==0) {
                MessageBox.Show("This is your second turn to play");
                Shoot = 0;
                Match = instance_Object.fireMatch();
                countShoot++;
            }
            //this block is used to over the game when to chances are over
            else if (countShoot==2) {
                MessageBox.Show("Unfortunately you lose the game ");
                ShootButton.Enabled = false;
                StartButton.Enabled = false;

            }
        }
    }
}
