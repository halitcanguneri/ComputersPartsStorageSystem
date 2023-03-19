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
    public partial class AddPanel : Form
    {
        public AddPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMotherboard form2 = new AddMotherboard();
            form2.Show();
            this.Hide();
        }

        private void AddPanel_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addCPU form2 = new addCPU();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addGPU form2 = new addGPU();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddRAM form2 = new AddRAM();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPSU form2 = new AddPSU();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddMonitor form2 = new AddMonitor();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddMouse form2 = new AddMouse();
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddKeyboard form2 = new AddKeyboard();
            form2.Show();
            this.Hide();
        }
    }
}
