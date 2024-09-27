using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Complete_The_Task_Goose_Chase_
{
    public partial class Win_Screen : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Win_Screen()
        {
            InitializeComponent();
        }
        private void Win_Screen_Load(object sender, EventArgs e){
            CenterToScreen();
            player = new System.Media.SoundPlayer(Properties.Resources.Yippee);
            player.Play();
        }

        private void Again_Click(object sender, EventArgs e){
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void picRefresh_Click(object sender, EventArgs e){
            player.Play();
        }

        private void picRefresh_MouseEnter(object sender, EventArgs e){
            //changes the back color of the refresh picture when mouse hovers over it
            picRefresh.BackColor = Color.LightGray;
        }

        private void picRefresh_MouseLeave(object sender, EventArgs e)
        {
            picRefresh.BackColor= Color.White;
        }
    }
}
