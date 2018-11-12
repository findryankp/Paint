using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            drawarenapanel.Refresh();
            this.drawarenapanel.BackgroundImage = null;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "PNG Files|*.png|JPEG Files|*.jpg";
            if(o.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                drawarenapanel.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
                drawarenapanel.BackgroundImageLayout = ImageLayout.Zoom;
            }
        }
    }
}
