using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerPartsSQL
{
    public partial class ShowKeyboardForUsers : Form
    {

        SqlConnection connection5 = new SqlConnection("Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True");
        DataTable dt = new DataTable();

        public ShowKeyboardForUsers()
        {
            InitializeComponent();
            UrunleriGetir();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Klavye ", connection5);
            adtr.Fill(dt);
            advancedDataGridView1.DataSource = dt;
        }

        public void UrunleriGetir()
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from Klavye ", connection);
            DataTable tablo = new DataTable();
            dat.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            userPanel form2 = new userPanel();
            form2.Show();
            this.Hide();
        }

        private void ShowKeyboardForUsers_Load(object sender, EventArgs e)
        {

        }
        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {

            dt.DefaultView.RowFilter = advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {

            dt.DefaultView.Sort = advancedDataGridView1.SortString;

        }
    }
}
