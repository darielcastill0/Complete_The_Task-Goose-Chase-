using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complete_The_Task_Goose_Chase_
{
    public partial class Lose_Screen : Form
    {
        public Lose_Screen()
        {
            InitializeComponent();
        }

        private void Lose_Screen_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.EXTREMELY_LOUD_INCORRECT_BUZZER);
            player.Play();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
