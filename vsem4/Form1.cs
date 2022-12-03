using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsem4
{
    public partial class Form1 : Form
    {
        ThreadApp ta = new ThreadApp();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox1.Text);
            
            Thread t = new Thread(ta.ThreadProd);
            t.Start(i);
            t.Join();
            MessageBox.Show("The accumlated product ="+ ta[0] +"*"+ ta[1]+"*"+ ta[2]+"*"+ ta[3]+" ="+ta.PROD);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
