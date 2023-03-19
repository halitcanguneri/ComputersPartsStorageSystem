using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ComputerPartsSQL
{
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        private void adminPanel_Load(object sender, EventArgs e)
        {
            //adminpanel form yeri
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPanel form2 = new AddPanel();
            form2.Show();
            this.Hide();
            // add butonudur

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePanel form2 = new UpdatePanel();
            form2.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowPanel form2 = new ShowPanel();
            form2.Show();
            this.Hide();
            //show butonu
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }
    }
}
