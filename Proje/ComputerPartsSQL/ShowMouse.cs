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
    public partial class ShowMouse : Form
    {
        public ShowMouse()
        {
            InitializeComponent();
        }

        public void UrunleriGetir()
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dat = new SqlDataAdapter("select * from Mouse ", connection);
            DataTable tablo = new DataTable();
            dat.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string sorgu = "delete from Mouse where UrunID=@UrunID";
            SqlCommand istek = new SqlCommand(sorgu, connection);
            istek.Parameters.AddWithValue("UrunID", Convert.ToInt32(textBox1.Text));
            connection.Open();
            istek.ExecuteNonQuery();
            connection.Close();
            UrunleriGetir();

        }

        SqlConnection connection5 = new SqlConnection("Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True");
        DataTable dt = new DataTable();

        private void ShowMouse_Load(object sender, EventArgs e)
        {
            UrunleriGetir();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Mouse ", connection5);
            adtr.Fill(dt);
            advancedDataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowPanel form2 = new ShowPanel();
            form2.Show();
            this.Hide();
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
