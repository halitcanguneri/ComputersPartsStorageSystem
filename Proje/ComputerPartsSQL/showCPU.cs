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
using System.Data.Sql;


namespace ComputerPartsSQL
{
    public partial class showCPU : Form
    {
        public showCPU()
        {
            InitializeComponent();
        }
        public void UrunleriGetir()
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from Islemci ", connection);
            DataTable tablo = new DataTable();
            dat.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();


        
        }
        private void ShowCPU_Load(object sender, EventArgs e)
        {
            UrunleriGetir();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string sorgu = "delete from Islemci where UrunID=@UrunID";
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

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel form2 = new ShowPanel();
            form2.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        SqlConnection connection5 = new SqlConnection("Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True");
        DataTable dt = new DataTable();

        private void showCPU_Load_1(object sender, EventArgs e)
        {
            UrunleriGetir();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Islemci ", connection5);
            adtr.Fill(dt);
            advancedDataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //string filter = "select * from Islemci where fiyat between @fiyat1 and @fiyat2";
            //SqlCommand istek = new SqlCommand(connectionString, connection);
            //istek.Parameters.AddWithValue("@fiyat1", textBox2.Text);
            //istek.Parameters.AddWithValue("@fiyat2", textBox3.Text);
            //istek.fill()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
