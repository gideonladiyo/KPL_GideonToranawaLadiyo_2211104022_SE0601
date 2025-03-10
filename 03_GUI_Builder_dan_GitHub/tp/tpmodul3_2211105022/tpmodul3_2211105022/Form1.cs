using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_2211105022
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = nameInput.Text;
            nameOutput.Text = $"Halo, {userInput}";

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
