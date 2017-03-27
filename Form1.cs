using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveRunAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Btn_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Á Hự...");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
