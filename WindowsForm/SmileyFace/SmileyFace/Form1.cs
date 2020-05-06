using SmileyFace.ClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Exam
{
    public partial class Form1 : Form
    {
        private int indexer = 0;
        public static Point aCenter = new Point(225, 225);
        public static Point aVelocity = new Point(15,15);

        Emoji aEmoji = new SmileFace(aCenter, aVelocity);

        public Form1()
        {
            InitializeComponent();
        }

        //Call draw method
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            aEmoji.Draw(e.Graphics);
        }

        //refresh face button
        private void button1_Click(object sender, EventArgs e)
        {
            switch (this.indexer)
            {
                case 0:
                    {
                        this.aEmoji = new NeutralFace(aCenter, aVelocity);
                    }
                    break;
                case 1:
                    {
                        this.aEmoji = new SadFace(aCenter, aVelocity);
                    }
                    break;
                case 2:
                    {
                        this.aEmoji = new SmileFace(aCenter, aVelocity);
                    }
                    break;
            }

            if (indexer == 2) { indexer = 0; }
            else { this.indexer++; }

            this.Repaint();
        }

        //repaint method
        private void Repaint()
        {
            this.pictureBox1.Invalidate();
            this.pictureBox1.Update();
            this.Refresh();
        }

        #region MoveButtons
        private void buttonUP_Click(object sender, EventArgs e)
        {
            aEmoji.Move(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height);
            aEmoji.Center.Y = aEmoji.Center.Y - aEmoji.Velocity.Y;
            this.Repaint();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            aEmoji.Move(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height);
            aEmoji.Center.Y = aEmoji.Center.Y + aEmoji.Velocity.Y;
            this.Repaint();
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            aEmoji.Move(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height);
            aEmoji.Center.X = aEmoji.Center.X + aEmoji.Velocity.X;
            this.Repaint();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            aEmoji.Move(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height);
            aEmoji.Center.X = aEmoji.Center.X - aEmoji.Velocity.X;
            this.Repaint();
        }
        #endregion

        #region ColorButtons
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.aEmoji.BackColor = Color.LightBlue;
            this.Repaint();
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            this.aEmoji.BackColor = Color.Gray;
            this.Repaint();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.aEmoji.BackColor = Color.Green;
            this.Repaint();
        }
        #endregion
    }
}
