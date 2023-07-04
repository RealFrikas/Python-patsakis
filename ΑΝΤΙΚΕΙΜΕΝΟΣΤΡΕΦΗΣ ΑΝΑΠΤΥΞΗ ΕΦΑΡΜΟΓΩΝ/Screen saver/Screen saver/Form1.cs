using System;
using System.Windows.Forms;
namespace Screen_saver
{
    public partial class Form1 : Form
    {
        int balls,countballs = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Start_saving_Click(object sender, EventArgs e)
        {
            string rawballs = textBox1.Text;
            balls = Int32.Parse(rawballs);
            Opacity = 0;
            ShowInTaskbar = false;;
            timer1.Enabled = true;
        }//converts text to int,deletes form and starts throwing balls
        private void textBox1_TextChanged(object sender, EventArgs e) {if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]")) {textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);}}//making sure user cant type letters
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countballs == balls - 1) {timer1.Enabled=false;}
            new Form2().Show();
            countballs++;
        }//throws balls one by one
    }
}