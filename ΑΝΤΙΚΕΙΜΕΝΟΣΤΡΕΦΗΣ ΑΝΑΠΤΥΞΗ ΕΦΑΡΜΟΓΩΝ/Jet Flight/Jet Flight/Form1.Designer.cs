namespace Jet_Flight
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Framepass = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.space1 = new System.Windows.Forms.PictureBox();
            this.space2 = new System.Windows.Forms.PictureBox();
            this.jet = new System.Windows.Forms.PictureBox();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.enemyjet = new System.Windows.Forms.PictureBox();
            this.scoreboard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.space1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.space2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyjet)).BeginInit();
            this.SuspendLayout();
            // 
            // Framepass
            // 
            this.Framepass.Interval = 17;
            this.Framepass.Tick += new System.EventHandler(this.Framepass_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "FLY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(45)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "SCORES";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(45)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Location = new System.Drawing.Point(589, 407);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 31);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "By Frikas  v0.01";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(45)))));
            this.namebox.Enabled = false;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.namebox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namebox.Location = new System.Drawing.Point(589, 12);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(199, 31);
            this.namebox.TabIndex = 2;
            this.namebox.Text = "JET FLIGHT";
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // space1
            // 
            this.space1.Image = global::Jet_Flight.Properties.Resources.space;
            this.space1.Location = new System.Drawing.Point(801, 0);
            this.space1.Name = "space1";
            this.space1.Size = new System.Drawing.Size(802, 450);
            this.space1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.space1.TabIndex = 1;
            this.space1.TabStop = false;
            // 
            // space2
            // 
            this.space2.BackColor = System.Drawing.Color.Transparent;
            this.space2.Image = global::Jet_Flight.Properties.Resources.space;
            this.space2.Location = new System.Drawing.Point(0, 0);
            this.space2.Name = "space2";
            this.space2.Size = new System.Drawing.Size(802, 450);
            this.space2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.space2.TabIndex = 0;
            this.space2.TabStop = false;
            // 
            // jet
            // 
            this.jet.BackColor = System.Drawing.Color.Transparent;
            this.jet.Image = global::Jet_Flight.Properties.Resources.Space_jet;
            this.jet.Location = new System.Drawing.Point(-200, 154);
            this.jet.Name = "jet";
            this.jet.Size = new System.Drawing.Size(100, 89);
            this.jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jet.TabIndex = 6;
            this.jet.TabStop = false;
            // 
            // Gametimer
            // 
            this.Gametimer.Interval = 80000;
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick);
            // 
            // enemyjet
            // 
            this.enemyjet.BackColor = System.Drawing.Color.Transparent;
            this.enemyjet.Image = global::Jet_Flight.Properties.Resources.Evil_jet;
            this.enemyjet.ImageLocation = "";
            this.enemyjet.Location = new System.Drawing.Point(900, 163);
            this.enemyjet.Name = "enemyjet";
            this.enemyjet.Size = new System.Drawing.Size(100, 119);
            this.enemyjet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyjet.TabIndex = 7;
            this.enemyjet.TabStop = false;
            // 
            // scoreboard
            // 
            this.scoreboard.AutoSize = true;
            this.scoreboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(45)))));
            this.scoreboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scoreboard.Location = new System.Drawing.Point(349, -203);
            this.scoreboard.Name = "scoreboard";
            this.scoreboard.Size = new System.Drawing.Size(57, 15);
            this.scoreboard.TabIndex = 8;
            this.scoreboard.Text = "Score: 0";
            this.scoreboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Jet_Flight.Properties.Resources.space;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enemyjet);
            this.Controls.Add(this.scoreboard);
            this.Controls.Add(this.jet);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.space2);
            this.Controls.Add(this.space1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jet flight";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.space1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.space2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Framepass;
        private System.Windows.Forms.PictureBox space2;
        private System.Windows.Forms.PictureBox space1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.PictureBox jet;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.PictureBox enemyjet;
        private System.Windows.Forms.Label scoreboard;
    }
}

