using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComputerPartsSQL
{
    public partial class UpdatePanel : Form
    {
        public UpdatePanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMotherboard form2 = new UpdateMotherboard();
            form2.Show();
            this.Hide();

        }

        private void UpdatePanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateCPU form2 = new updateCPU();
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGPU form2 = new UpdateGPU();
            form2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateRAM form2 = new UpdateRAM();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdatePSU form2 = new UpdatePSU();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateMonitor form2 = new UpdateMonitor();
            form2.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateMouse form2 = new UpdateMouse();
            form2.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UpdateKeyboard form2 = new UpdateKeyboard();
            form2.Show();
            this.Hide();
        }
    }
}

