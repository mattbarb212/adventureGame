using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace adventureGame
{
    public partial class adventureGame : Form
    {
        int scene = 0;

        SoundPlayer winPlayer = new SoundPlayer(Properties.Resources._518855__mrickey13__fight_win_tune);
        SoundPlayer deathPlayer = new SoundPlayer(Properties.Resources._320247__nicktermer__scream);
        SoundPlayer scenePlayer = new SoundPlayer(Properties.Resources._332854__robinhood76__06246_ghostly_hit);
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
                    outputLabel.Text = "You are in a hallway with a door to the left that says do not enter you will die and the right that says " +
                        "exit which one do you want to go through?";
                    redLabel.Text = "Right";
                    blueLabel.Text = "Left";
                    pictureBox.BackgroundImage = Properties.Resources.scene_0;
                    scenePlayer.Play();
                    break;
                case 1:
                    outputLabel.Text = "You walk through the door and a voice says, Welcome, Do you want to play a game";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.scene_1;
                    scenePlayer.Play();
                    break;
                case 2:
                    outputLabel.Text = "You walk through the door and you exit to the city, Yay you escaped do you want to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.scene_1;
                    winPlayer.Play();
                    break;
                case 3:
                    outputLabel.Text = "The walls of the room start to close and a voice tells you to enter but remember that the truth " +
                        "may not be reality. Do you walk through?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.scene_3;
                    scenePlayer.Play();
                    break;
                case 4:
                    outputLabel.Text = "A voice says too bad and laughs, the walls start to close in and a door opens. Do you walk through?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.scene_3;
                    scenePlayer.Play();
                    break;                    
                case 5:
                    outputLabel.Text = "You walk into the next room and the door closes behind you. On the wall reads What Roman Numeral is equal to 56?";
                    redLabel.Text = "XLVIII";
                    blueLabel.Text = "LVI";
                    pictureBox.BackgroundImage = Properties.Resources.scene_5;
                    scenePlayer.Play();
                    break;
                case 6:
                    outputLabel.Text = "The walls close and you are crushed. Do you want to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 7:
                    outputLabel.Text = "The door opens and a 30 second clock starts to count down. Do you walk through or do you wait?";
                    redLabel.Text = "Walk Through";
                    blueLabel.Text = "Wait";
                    pictureBox.BackgroundImage = Properties.Resources.scene_7;
                    scenePlayer.Play();
                    break;
                case 8:  
                    outputLabel.Text = "The doors lock and a poison gas begins to fill the room, shortly after you pass out and die. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 9:
                    outputLabel.Text = "You walk into the next room and there is a glass in the room with a saw beside" +
                        " it and it says to fill it with blood to leave the room. Do you cut your hand off or do you try pushing down on the pressure plate?";
                    redLabel.Text = "Weight";
                    blueLabel.Text = "Hand";
                    pictureBox.BackgroundImage = Properties.Resources.scene_9;
                    scenePlayer.Play();
                    break;
                case 10:
                    outputLabel.Text = "You were hit in the leg with a spear but are still alive. You walk into the next " +
                        "room and there is a glass in the room with a saw beside it and it says to fill it with blood to " +
                        "leave the room. Do you cut your hand off or do you try pushing down on the pressure plate?";
                    redLabel.Text = "Weight";
                    blueLabel.Text = "Hand";
                    pictureBox.BackgroundImage = Properties.Resources.scene_9;
                    scenePlayer.Play();
                    break;
                case 11:
                    outputLabel.Text = "You were impaled by a spear and died. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 12:
                    outputLabel.Text = "The door opens and you see outside, you walk through the door and see a pay " +
                        "phone one way and a house the other. which way do you run?";
                    redLabel.Text = "Phone";
                    blueLabel.Text = "House";
                    pictureBox.BackgroundImage = Properties.Resources.scene_12;
                    scenePlayer.Play();
                    break;
                case 13:
                    outputLabel.Text = "You cut off your hand and start to fill the glass with your blood. The door clicks " +
                        "and opens but as your walking through everything goes blurry and you die from blood loss. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 14:
                    outputLabel.Text = "You run to the house and see the front door the garage door and a window which one do you go to?";
                    redLabel.Text = "Garage Door";
                    blueLabel.Text = "Window";
                    greenLabel.Text = "Front Door";
                    pictureBox.BackgroundImage = Properties.Resources.scene_14;
                    scenePlayer.Play();
                    break;
                case 15:
                    outputLabel.Text = "You pick up the phone and and you hear is beeping, the phone blows up and you die. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 16:
                    greenLabel.Text = "";
                    outputLabel.Text = "You come to the front door and when you touch the handle you get electrocuted and die. Do you want to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 17:
                    greenLabel.Text = "";
                    outputLabel.Text = "You walk into the garage and see a door and a basketball net. Do you start to shoot baskets or do you walk through the door?";
                    redLabel.Text = "Door";
                    blueLabel.Text = "Basketball";
                    pictureBox.BackgroundImage = Properties.Resources.scene_16;
                    scenePlayer.Play();
                    break;
                case 18:
                    greenLabel.Text = "";
                    outputLabel.Text = "You run you the window and jump through it getting covered in glass, a piece cuts your " +
                        "throat and you die. Do you want to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;               
                case 20:
                    outputLabel.Text = "You hit a fade away three pointer and the door opens. You walk through the door into " +
                        "your childhood bedroom and the voice says to destroy the thing you love to escape. From what " +
                        "you remember you loved your blanket and teddy equally which one do you rip apart?";
                    redLabel.Text = "Blanket";
                    blueLabel.Text = "Teddy";
                    pictureBox.BackgroundImage = Properties.Resources.scene_19;
                    scenePlayer.Play();
                    break;
                case 21:
                    outputLabel.Text = "You try to open the door and a voice says only ballers get through. Spikes shoot out the door. " +
                        "You dodge the spikes and go back to hit a three point shot that opens the door. You walk through the door into " +
                        "your childhood bedroom and the voice says to destroy the thing you love to escape. From what you remember you " +
                        "loved your blanket and teddy equally which one do you rip apart?";
                    redLabel.Text = "Blanket";
                    blueLabel.Text = "Teddy";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 22:
                    outputLabel.Text = "You try to open the door and a voice says only ballers get through. Spikes shoot out the door. " +
                        "The spikes hit you and you die. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 23:
                    outputLabel.Text = "You rip apart the blanket and a key that says window on it. You take it to the window and it opens, " +
                        "you walk out and run toward the city. Congratulations, you have escaped, for now. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.scene_12;
                    winPlayer.Play();
                    break;
                case 24:
                    outputLabel.Text = "You rip apart the teddy and a ticking bomb blows you up and you die. Would you like to play again?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.BackgroundImage = Properties.Resources.death_scene;
                    deathPlayer.Play();
                    break;
                case 25:
                    outputLabel.Text = "Thanks for playing";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    pictureBox.BackgroundImage = Properties.Resources.scene_12;

                    Refresh();
                    Thread.Sleep(3000);

                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
