using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Screen_saver
{
    public partial class Form2 : Form
    {
        Random rdirect = new Random();
        int[] dir = new int[2];
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(rdirect.Next(0, 1800), rdirect.Next(0, 955));
            Framerate.Enabled = true;
            FormBorderStyle = FormBorderStyle.None;
            Size = new Size(50, 50);
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(0,0, 50, 50);
            Region = new Region(shape);
            BackColor = Color.FromArgb(rdirect.Next(0, 256), rdirect.Next(0, 256), rdirect.Next(0, 256));//random!!!
            do
            {
                dir[0] = rdirect.Next(-10, 11);
                dir[1] = rdirect.Next(-10, 11);
            }while(dir[0] == 0 || dir[1] == 0);
        }
        private void Framerate_Tick(object sender, EventArgs e)
        {
            Location = new Point(Location.X + dir[0], Location.Y + dir[1]);
            if (Location.X <= 0 || Location.X+50 >= Screen.PrimaryScreen.Bounds.Width) {dir[0] = dir[0] * -1;}
            if (Location.Y <= 0 || Location.Y+50 >= Screen.PrimaryScreen.Bounds.Height) {dir[1] = dir[1] * -1;}
        }//move form around screen
    }
}
