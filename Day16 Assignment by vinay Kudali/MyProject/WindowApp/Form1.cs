using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PublicLibrary;
using Vinay1Library;

namespace WindowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input=Convert.ToInt32(textBox1.Text);   
            int fact=Mathematics.Fact(input);
            textBox2.Text = fact.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
