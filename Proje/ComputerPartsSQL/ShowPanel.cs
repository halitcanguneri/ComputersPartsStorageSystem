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
    public partial class ShowPanel : Form
    {
        public ShowPanel()
        {
            InitializeComponent();
        }

        private void ShowPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowMotherboard form2 = new ShowMotherboard();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showCPU form2 = new showCPU();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowGPU form2 = new ShowGPU();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowRAM form2 = new ShowRAM();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPSU form2 = new ShowPSU();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowMonitor form2 = new ShowMonitor();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowMouse form2 = new ShowMouse();
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowKeyboard form2 = new ShowKeyboard();
            form2.Show();
            this.Hide();
        }
    }
}
