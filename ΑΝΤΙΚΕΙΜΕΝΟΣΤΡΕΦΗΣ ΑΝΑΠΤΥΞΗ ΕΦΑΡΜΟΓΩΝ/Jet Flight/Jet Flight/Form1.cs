using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Jet_Flight
{
    public partial class Form1 : Form
    {
        private bool fired,flyp,gamend,up,down = false; //flyp = fly button pressed,and finished game //button presses used
        private int firewait,minit,count,curscore = 0;//counter(make it random later) to move ai,mini timer is for moving meny sequence
        private int rdirect = 3; //for enemy jet
        Random rdirection = new Random();
        List<PictureBox> lazers = new List<PictureBox>();
        List<PictureBox> badlazers = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            Framepass.Start();
        }
        private void Framepass_Tick(object sender, EventArgs e)
        {
            Movespaces();
            if (fired == true) {firewait++;}
            else {firewait = 0;}
            if (firewait >= 8) {fired = false;}
            if (flyp == true) {Moveaway(); }//for starting the game
            if (gamend == true){Comeback(); }//for ending the game
            Jetmove();
            Lasertravel();
        }//whatever moves at ~60fps
        private void Movespaces()     //handles the background movement
        {
            if (space1.Location.X == -802) {space1.Location = new Point(801, 0);}
            else if (space2.Location.X == -802) {space2.Location = new Point(801, 0);}
            space1.Location = new Point(space1.Location.X - 1, space1.Location.Y);
            space2.Location = new Point(space2.Location.X - 1, space2.Location.Y);
        }
        private void button1_Click(object sender, EventArgs e) {flyp = true;}//start button
        private void button2_Click(object sender, EventArgs e)
        {
            scoreboard show = new scoreboard();
            show.ShowDialog();
        }//open score board
        private void Moveaway() //handles the boxes moving away to start game
        {
            button1.Enabled = false;
            button2.Enabled = false;
            scoreboard.Location = new Point(scoreboard.Location.X, scoreboard.Location.Y + 3);
            textBox2.Location = new Point(textBox2.Location.X + 3, textBox2.Location.Y);
            namebox.Location = new Point(namebox.Location.X + 3, namebox.Location.Y);
            button1.Location = new Point(button1.Location.X - 3, button1.Location.Y);
            button2.Location = new Point(button2.Location.X - 3, button2.Location.Y);
            jet.Location = new Point(jet.Location.X + 3, jet.Location.Y);
            enemyjet.Location = new Point(enemyjet.Location.X - 3, enemyjet.Location.Y);
            minit = minit + 3;
            if (minit >= 212)
            {
                flyp = false;
                button1.Visible = false;
                button2.Visible = false;
                Gametimer.Start();
                Focus();
                //SoundPlayer gmusic = new SoundPlayer(Properties.Resources.MMT);
                //gmusic.Play();
            }//If you want the mmt to work disable the gun sound effects!!!
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {up = true;}
            if (e.KeyCode == Keys.Down) {down = true;}
        }//key presses check
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {up = false;}
            if (e.KeyCode == Keys.Down) {down = false;}
        }//key releases check
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && Gametimer.Enabled == true && fired == false)
            {
                fired = true;
                PictureBox pew = new PictureBox();  //spawn picturebox,friendly laser
                SoundPlayer sfpew = new SoundPlayer(Properties.Resources.pew);
                sfpew.Play();
                pew.Location = new Point(jet.Location.X + 100, jet.Location.Y + 42);
                pew.Image = Properties.Resources.bullet_frien;
                pew.Size = new Size(50, 10);
                pew.BackColor = Color.Transparent;
                pew.SizeMode = PictureBoxSizeMode.StretchImage;
                lazers.Add(pew);
                Controls.Add(pew);
                pew.BringToFront();
            }
        }//player fire button  //check if game started and shoot with space
        private void Jetmove()
        {   //friendle jet movement
            if (up == true && jet.Location.Y > 3) {jet.Location = new Point(jet.Location.X, jet.Location.Y - 6);}
            if (down == true && jet.Location.Y < 447 - jet.Size.Height) {jet.Location = new Point(jet.Location.X, jet.Location.Y + 6);}
            count = count + 1; //enemy jet movement
            if (count == 7)
            {
                count = 0;
                int aiud = rdirection.Next(1, 10);//decides up and down for ai
                if (aiud / 2 == 0) {rdirect = 3;}
                else if (aiud / 2 == 1) {rdirect = -3;}
            }
            if (count == 1 || count == 4)//ai decides to shoot
            {
                int shot = rdirection.Next(1, 11);
                if (shot < 2 && Gametimer.Enabled == true)
                {
                    PictureBox badpew = new PictureBox();
                    SoundPlayer sfpew = new SoundPlayer(Properties.Resources.pew);
                    sfpew.Play();
                    badpew.Location = new Point(enemyjet.Location.X - 50, enemyjet.Location.Y + 60);
                    badpew.Image = Properties.Resources.enemilaser;
                    badpew.Size = new Size(50, 10);
                    badpew.BackColor = Color.Transparent;
                    badpew.SizeMode = PictureBoxSizeMode.StretchImage;
                    badlazers.Add(badpew);
                    Controls.Add(badpew);
                    badpew.BringToFront();
                }
            }
            if (enemyjet.Location.Y < 1 || enemyjet.Location.Y > 450 - enemyjet.Size.Height) {rdirect = -rdirect;}//check for boundries
            if (Gametimer.Enabled == true) {enemyjet.Location = new Point(enemyjet.Location.X, enemyjet.Location.Y + rdirect);}//ai move
        }//player movement and ai "thinking"
        private void Lasertravel()
        {
            foreach (PictureBox pew in lazers)
            {
                pew.Location = new Point(pew.Location.X + 9, pew.Location.Y);
                if (pew.Location.X >= enemyjet.Location.X - pew.Width && pew.Location.X <= 800 && pew.Location.Y >= enemyjet.Location.Y && pew.Location.Y <= enemyjet.Location.Y + enemyjet.Height)
                {
                    curscore = curscore + 100;
                    scoreboard.Text = "Score:" + curscore;
                    pew.Location = new Point(pew.Location.X, -100);
                }
                else if (pew.Location.X == 800) {}
            }
            foreach (PictureBox badpew in badlazers)
            {
                badpew.Location = new Point(badpew.Location.X - 9, badpew.Location.Y);
                if (badpew.Location.X <= jet.Width && badpew.Location.X >= jet.Location.X && badpew.Location.Y >= jet.Location.Y && badpew.Location.Y <= jet.Location.Y + jet.Height)
                {
                    curscore = curscore - 100;
                    scoreboard.Text = "Score:" + curscore;
                    badpew.Location = new Point(badpew.Location.X, -100);
                }
                else if (badpew.Location.X == -badpew.Width) {}
            }
        }//bullet movement and collision
        private void Comeback()
        {
            button1.Visible = true;
            button2.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            scoreboard.Location = new Point(scoreboard.Location.X, scoreboard.Location.Y - 3);
            textBox2.Location = new Point(textBox2.Location.X - 3, textBox2.Location.Y);
            namebox.Location = new Point(namebox.Location.X - 3, namebox.Location.Y);
            button1.Location = new Point(button1.Location.X + 3, button1.Location.Y);
            button2.Location = new Point(button2.Location.X + 3, button2.Location.Y);
            jet.Location = new Point(jet.Location.X - 3, jet.Location.Y);
            enemyjet.Location = new Point(enemyjet.Location.X + 3, enemyjet.Location.Y);
            minit = minit - 3;//tells when animation end
            if (minit <= 0)
            {
                gamend = false;
                jet.Location = new Point(-200, 154);
                enemyjet.Location = new Point(900, 163);
            }
        }//brings you back to the menu
        private void Gametimer_Tick(object sender, EventArgs e)
        {
            gamend = true;
            Gametimer.Enabled = false;
            Updatescores();
        }//timer that says when game has ended
        private void Updatescores()
        {
            int[] allscore = new int[10];       //read the file and make it int
            string rawscore = File.ReadAllText("Scores.txt");
            string[] arrayedscore = rawscore.Split(',');
            for (int i = 0; i < 10; i++) {allscore[i] = Int32.Parse(arrayedscore[i]);}
            if (curscore > allscore[9])//dectides if its top 10 to save
            {
                for (int i = 0; i<10; i++)
                {
                    int x;
                    if (curscore > allscore[i])
                    {
                        x = allscore[i];
                        allscore[i] = curscore;
                        curscore = x;
                    }
                }
                curscore = 0;
                for (int i = 0; i < 10; i++) {arrayedscore[i] = Convert.ToString(allscore[i]);}
                rawscore = arrayedscore[0] + "," + arrayedscore[1] + "," + arrayedscore[2] + "," + arrayedscore[3] + "," +arrayedscore[4] + "," + arrayedscore[5] + "," + arrayedscore[6] + "," + arrayedscore[7] + "," + arrayedscore[8] + "," + arrayedscore[9];
                File.WriteAllText("Scores.txt", rawscore);
            }
        }//writes the new scoreboard
    }
}