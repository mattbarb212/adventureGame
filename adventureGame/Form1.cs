using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureGame
{
    public partial class adventureGame : Form
    {
        int scene = 0;
        public adventureGame()
        {
            InitializeComponent();
        }

        private void AdventureGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 25;
                }
                else if (scene == 3)
                {
                    scene = 6;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 8;
                }
                else if (scene == 6)
                {
                    scene = 25;
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {
                    scene = 25;
                }
                else if (scene == 9)
                {
                    scene = 12;
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 11)
                {
                    scene = 25;
                }
                else if (scene == 12)
                {
                    scene = 15;
                }
                else if (scene == 13)
                {
                    scene = 25;
                }
                else if (scene == 14)
                {
                    scene = 17;
                }
                else if (scene == 15)
                {
                    scene = 25;
                }
                else if (scene == 16)
                {
                    scene = 25;
                }
                else if (scene == 17)
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 101);

                    if (value < 20) { scene = 21; }
                    else { scene = 22; }
                }
                else if (scene == 18)
                {
                    scene = 25;
                }                
                else if (scene == 20)
                {
                    scene = 23;
                }
                else if (scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 22)
                {
                    scene = 25;
                }
                else if (scene == 23)
                {
                    scene = 25;
                }
                else if (scene == 24)
                {
                    scene = 25;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {

                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 0; }
                else if (scene == 3) { scene = 5; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 7; }
                else if (scene == 6) { scene = 0; }
                else if (scene == 7)
                {
                    Random randGen = new Random();
                    int value = randGen.Next(1, 101);

                    if (value < 50) { scene = 11; }
                    else { scene = 10; }
                }
                else if (scene == 8) { scene = 0; }
                else if (scene == 9) { scene = 13; }
                else if (scene == 10) { scene = 13; }
                else if (scene == 11) { scene = 0; }
                else if (scene == 12) { scene = 14; }
                else if (scene == 13) { scene = 0; }
                else if (scene == 14) { scene = 18; }
                else if (scene == 15) { scene = 0; }
                else if (scene == 16) { scene = 0; }
                else if (scene == 17) { scene = 20; }
                else if (scene == 18) { scene = 0; }                
                else if (scene == 20) { scene = 24; }
                else if (scene == 21) { scene = 24; }
                else if (scene == 22) { scene = 0; }
                else if (scene == 23) { scene = 0; }
                else if (scene == 24) { scene = 0; }
            }
            else if (e.KeyCode == Keys.Space)  //green button press
            {
                if (scene == 14) { scene = 16; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene  
                    outputLabel.Text = "You are in a hallway with a door to the left and the right which one do you want to go through?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    break;
                case 1:
                    outputLabel.Text = "You walk through the door and a voice says, Welcome, Do you want to play a game";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 2:
                    outputLabel.Text = "You walk through the door and you exit to the city, Yay you escaped do you want to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 3:
                    outputLabel.Text = "The walls of the room start to close and a voice tells you to enter but remember that the truth may not be reality. Do you walk through?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                case 4:
                    outputLabel.Text = "A voice says too bad and laughs, the walls start to close in and a door opens. Do you walk through?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    break;
                    //Ended the day here
                case 5:
                    outputLabel.Text = "You tame the horse and ride to safety, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 7:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 8:  
                    outputLabel.Text = "You are lost in a forest which way do you want to go";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 9:
                    outputLabel.Text = "You come to a lake do you want to drink";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You fall in a pit and die, Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "The water is stagent, you die of Cholera, Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "A horse swims by do you try to ride it";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You tame the horse and ride to safety, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 16:   
                    outputLabel.Text = "You are lost in a forest which way do you want to go";
                    redLabel.Text = "North";
                    blueLabel.Text = "South";
                    break;
                case 17:
                    outputLabel.Text = "You come to a lake do you want to drink";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "You fall in a pit and die, Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;               
                case 20:
                    outputLabel.Text = "A horse swims by do you try to ride it";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = "You tame the horse and ride to safety, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 23:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 24:
                    outputLabel.Text = "The horse swims by and you die of loneliness, Play again";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 25:
                    outputLabel.Text = "Thanks for playing";
                    redLabel.Text = "";
                    blueLabel.Text = "";




                    break;
                default:
                    break;
            }
        }
    }
}
