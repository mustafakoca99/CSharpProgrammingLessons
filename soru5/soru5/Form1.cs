using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 45;
            int c = 96;
            int d = 12;
            if (c<d)
            {
                this.BackColor = Color.Green;
                label1.Text = "Yeşil";
            }
            else if (a>=d && d>c) 
            {
                this.BackColor = Color.Yellow;
                label1.Text = "Sarı";
            }
            else if (c>a||a<=d )
            {
                this.BackColor = Color.Blue;
                label1.Text = "Mavi";
            }
            else
            {
                this.BackColor = Color.Red;
                label1.Text = "Kırmızı";
            }
        }

    }
}
