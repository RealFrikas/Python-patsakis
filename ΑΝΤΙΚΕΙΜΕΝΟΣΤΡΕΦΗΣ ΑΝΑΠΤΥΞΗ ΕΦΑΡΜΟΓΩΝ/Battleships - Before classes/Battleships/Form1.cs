using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[] Emap = new int[100];
        int[] Pmap = new int[100];
        int[] Esunk = new int[4];
        int[] Psunk = new int[4];
        string[] ships = new string[4];
        int Pshots, Eshots = 0;
        public Form1()
        {
            InitializeComponent();
            ships[0] = "Υποβρύχιο";
            ships[1] = "Πολεμικό";
            ships[2] = "Αντιτορπιλικό";
            ships[3] = "Αεροπλανοφόρο";

            

            for (int i = 2; i < 6; i++)
            {
                placeship(i, Emap);
                placeship(i, Pmap);
            }
        }

        private void placeship(int size, int[] map)
        {
            int orientation = r.Next(0, 2);
            int move = 1;
            int location;
            //check vertical or horisontal placement
            if (orientation == 1)
            {
                move = 10;
            }
            bool placement;
            do
            {
                //finds a random box and checks availability
                location = r.Next(0, 100);
                placement = true;
                for (int i = 0; i < size; i++)
                {
                    //checks for vertical boundary || checks for horisontal boundary || checks for collision
                    if (location > 99 || location % 10 < (location - move) % 10 || map[location] != 0)
                    {
                        placement = false;
                        break;
                    }
                    location = location + move;
                }
                //if check ok, draw ship
                if (placement == true)
                {
                    for (int i = 0; i < size; i++)
                    {
                        location = location - move;
                        map[location] = size;
                    }
                }
            } while (placement == false);
        }

        private void E1_Click(object sender, EventArgs e)
        {
            string halfloc = ((Label)sender).Name.Substring(1);
            int loc = Convert.ToInt32(halfloc);
            loc--;
            if (((Label)sender).BackColor == Color.CornflowerBlue)
            {
                if (Emap[loc] != 0)
                {
                    ((Label)sender).BackColor = Color.Red;
                    Esunk[Emap[loc] - 2]++;
                    if (Esunk[Emap[loc] - 2] == Emap[loc])
                    {
                        Chat.ForeColor = Color.Red;
                        Chat.Text = "Βυθίστηκε το " + ships[Emap[loc] - 2] + " μου";
                        Pshots++;
                        if (Pshots == 4)
                        {
                            endgame("Παίχτης");
                        }
                    }
                    enemyshot();
                }
                else
                {
                    ((Label)sender).BackColor = Color.White;
                    enemyshot();
                }
            }
        }

        private void enemyshot()
        {
            int shot;
            bool unclear = true;
            //making sure the spot isn't already shot
            do
            {
                shot = r.Next(0, 100);
                Label playerbox = Controls.Find("P" + (shot + 1), true).FirstOrDefault() as Label;
                if(playerbox.BackColor == Color.DeepSkyBlue)
                {
                    unclear = false;
                }
            } while (unclear);
            Label visualloc = Controls.Find("P" + (shot + 1), true).FirstOrDefault() as Label;
            //making the shot
            if (Pmap[shot] != 0)
            {
                visualloc.BackColor = Color.Red;
                Psunk[Pmap[shot] - 2]++;
                if (Psunk[Pmap[shot] - 2] == Pmap[shot])
                {
                    Chat.ForeColor = Color.Blue;
                    Chat.Text = "Βυθίστηκε το " + ships[Pmap[shot] - 2] + " μου";
                    Eshots++;
                    if (Eshots == 4)
                    {
                        endgame("Εχθρός");
                    }
                }
            }
            else
            {
                visualloc.BackColor = Color.White;
            }
        }
        int[] score = new int[2];
        private void endgame(string winner)
        {
            gameovertext.Text = "Νικησε ο " + winner + " σε χρονο " + time;
            if (winner == "Παίχτης")
            {
                score[0]++;
            }
            else
            {
                score[1]++;
            }
            scoreboard.Text = "Σκορ: " + score[0] + "|" + score[1];
            gameovertext.Location = new Point(801, 242);
            retrybutton.Location = new Point(908, 300);
            exitbutton.Location = new Point(908, 329);
            scoreboard.Location = new Point(872, 355);
            for(int i = 1;i < 101; i++)
            {
                Label playertiles = Controls.Find("E" + i, true).FirstOrDefault() as Label;
                playertiles.Enabled = false;
            }
        }

        private void retrybutton_Click(object sender, EventArgs e)
        {
            time = 0;
            Eshots = 0;
            Pshots = 0;
            for (int i = 0; i < 100; i++)
            {
                Emap[i] = 0;
                Pmap[i] = 0;
            }
            for (int i = 2; i < 6; i++)
            {
                Esunk[i - 2] = 0;
                Psunk[i - 2] = 0;
                placeship(i, Emap);
                placeship(i, Pmap);
            }
            Chat.Text = "";
            gameovertext.Location = new Point(1980, 242);
            retrybutton.Location = new Point(1980, 300);
            exitbutton.Location = new Point(1980, 329);
            scoreboard.Location = new Point(1980, 355);
            for (int i = 1; i < 101; i++)
            {
                Label playertiles = Controls.Find("E" + i, true).FirstOrDefault() as Label;
                Label enemytiles = Controls.Find("P" + i, true).FirstOrDefault() as Label;
                playertiles.Enabled = true;
                enemytiles.BackColor = Color.DeepSkyBlue;
                playertiles.BackColor = Color.CornflowerBlue;
            }
            //everything blue,buttons on
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
            //close and save to database
        }

        int time = 0;
        private void Time_Tick(object sender, EventArgs e)
        {
            time++;
        }
    }
}
