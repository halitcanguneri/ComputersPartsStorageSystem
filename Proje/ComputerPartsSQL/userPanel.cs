using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsSQL
{
    public partial class userPanel : Form
    {
        public userPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMotherboardForUsers form2 = new ShowMotherboardForUsers();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowCPUForUsers form2 = new ShowCPUForUsers();
            form2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowGPUForUsers form2 = new ShowGPUForUsers();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRAMForUsers form2 = new ShowRAMForUsers();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPSUForUsers form2 = new ShowPSUForUsers();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowMonitorForUsers form2 = new ShowMonitorForUsers();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowMouseForUsers form2 = new ShowMouseForUsers();
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowKeyboardForUsers form2 = new ShowKeyboardForUsers();
            form2.Show();
            this.Hide();
        }

        private void userPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
