using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string l1 = listBox1.SelectedItem.ToString();
            string l2 = listBox2.SelectedItem.ToString();
            
            
            string text = l2.Substring(1, 1);
            Console.WriteLine(text);

            
            
            int i = int.Parse(l1) - int.Parse(text);
            
            label4.Text = i.ToString();
        
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close ();
        }
    }
}
