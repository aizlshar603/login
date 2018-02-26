using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string password;
            name = nameInput.Text;

           // outputLabel.Text= 
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = Name;
        }
    }
}
