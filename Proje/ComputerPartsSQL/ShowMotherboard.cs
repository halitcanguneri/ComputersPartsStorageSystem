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
using System.Data.Common;

namespace ComputerPartsSQL
{
    public partial class ShowMotherboard : Form
    {
        public ShowMotherboard()
        {
            InitializeComponent();

        }

        public void UrunleriGetir()
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from Anakart ",connection);
            DataTable tablo = new DataTable();
            dat.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();


        }

        SqlConnection connection5 = new SqlConnection("Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True");
        DataTable dt = new DataTable();

        private void ShowMotherboard_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Anakart ", connection5);
            adtr.Fill(dt);
            advancedDataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string sorgu = "delete from Anakart where UrunID=@UrunID";
            SqlCommand istek = new SqlCommand(sorgu, connection);
            istek.Parameters.AddWithValue("UrunID", Convert.ToInt32(textBox1.Text));
            connection.Open();
            istek.ExecuteNonQuery();
            connection.Close();
            UrunleriGetir();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel form2 = new ShowPanel();
            form2.Show();
            this.Hide();
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Anakart where UrunID like'" + textBox2.Text + "%'", connection);
            connection.Open();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dt.Clear();
            //string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Anakart where UrunID like'"+textBox2.Text+"%'",connection);
            //connection.Open();
            //sorgu.Fill(dt);
            
            //dataGridView1.DataSource = dt;
            //connection.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dt.Clear();
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Anakart" +
                " where Fiyat between " +
                "" + textBox5.Text + " and " +
                "" + textBox6.Text, connection);
            connection.Open();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Anakart where UrunAdi like'" + textBox4.Text + "%'", connection);
            connection.Open();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sorgu = new SqlDataAdapter("Select * from Anakart where Marka like'" + textBox3.Text + "%'", connection);
            connection.Open();
            sorgu.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
