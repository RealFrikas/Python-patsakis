using System;
using System.Windows.Forms;
using System.IO;

namespace Jet_Flight
{
    public partial class scoreboard : Form
    {
        public scoreboard()
        {
            InitializeComponent();
            int[] allscore = new int[10];       //read the file and make it int
            string rawscore = File.ReadAllText("Scores.txt");
            string[] arrayedscore = rawscore.Split(',');
            Putlabes(arrayedscore);
            for (int i=0; i<10; i++) {allscore[i] = Int32.Parse(arrayedscore[i]);}
        }
        private void Putlabes(string []x)//sets the numbers
        {
            label2.Text = x[0];
            label3.Text = x[1];
            label4.Text = x[2];
            label5.Text = x[3];
            label6.Text = x[4];
            label7.Text = x[5];
            label8.Text = x[6];
            label9.Text = x[7];
            label10.Text = x[8];
            label11.Text = x[9];
        }
    }
}
