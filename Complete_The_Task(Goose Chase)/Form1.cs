using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Complete_The_Task_Goose_Chase_
{
    public partial class Form1 : Form
    {
        bool dragging;
        int xoffset;
        int yoffset;
        bool[] correct = new bool[12]; //keeps track of which answers are correct

        
        Button b;
        PictureBox pic;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public Form1()
        {
            InitializeComponent();
            dragging = false;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            b = (Button)sender;
                timer1.Interval = 1000;
                timer1.Start();
                dragging = true;
                //set to the mouse poniter position
                xoffset = e.X;
                yoffset = e.Y;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //position change of mouse pointer (relative to Button coords)
            int XMoved;
            int YMoved;
            //Calculated postition change of mouse pointer
            int newBtnX;
            int newBtnY;


            if (dragging)
            {
                b = (Button)sender;
                //calculate mouse pointer movement
                XMoved = e.Location.X - xoffset;
                YMoved = e.Location.Y - yoffset;

                // Calculate new pos of button 
                //Current pos plus the number of pixels that the mouse moved
                newBtnX = b.Location.X + XMoved;
                newBtnY = b.Location.Y + YMoved;

                //Move button
                b.Location = new Point(newBtnX, newBtnY);
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

            //plays the win gif and sound if all answers are correct
             if(correct.All(x => x)){
                timer1.Stop();
                Win_Screen win_Screen = new Win_Screen();
                this.Hide();
                win_Screen.Show();
               
            }
        }

        //When the user releases the mouse button, the click event of each button will check for intersection
        //with it's corresponing picture box.
        private void button1_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox1;
            correct[0] = Check_Intersection(b,pic);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox2;
            correct[1] = Check_Intersection(b, pic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox3;
            correct[2] = Check_Intersection(b, pic);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox4;
            correct[3] = Check_Intersection(b, pic);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox5;
            correct[4] = Check_Intersection(b, pic);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox6;
            correct[5] = Check_Intersection(b, pic);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox7;
            correct[6] = Check_Intersection(b, pic);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox8;
            correct[7] = Check_Intersection(b, pic);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox9;
            correct[8] = Check_Intersection(b, pic);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox10;
            correct[9] = Check_Intersection(b, pic);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox11;
            correct[10] = Check_Intersection(b, pic);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = (Button)sender;
            pic = pictureBox12;
            correct[11] = Check_Intersection(b, pic);
        }

        private bool Check_Intersection(Button b, PictureBox pic){
            //checks for intersection of button and picture box
            bool intersect = pic.Bounds.IntersectsWith(b.Bounds);

            if (intersect)
            {
                pic.BackColor = Color.Green;
                return true;
            }
            else{
                pic.BackColor = Color.Transparent;
                return false;
            }
                
        }

        int counter = 35;
        private void timer1_Tick(object sender, EventArgs e){
            //The counter will tick down every second
            counter -= 1;
            if (counter <= 0){
                timer1.Stop();
                //opens the lose screen form
                this.Hide();
                Lose_Screen lose = new Lose_Screen();
                lose.Show();
            }
            else{
                lblTimer.Text = "Time Left: " + counter + "s";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = "Time Left: " + counter + "s";

        }
    }
}
