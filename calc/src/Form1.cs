using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public int a, b;
        public char sign;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_Click(object sender, EventArgs e)
        {
		    
		    char ch = sender.ToString()[sender.ToString().Length - 1];
		    textbox.Text = cr.choose(ch.ToString());	
        }


       

    
    }
}
