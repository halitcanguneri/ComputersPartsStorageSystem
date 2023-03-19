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
    public partial class AddMotherboard : Form
    {
        public AddMotherboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO Anakart (" +
                "UrunID," +
                "Marka," +
                "UrunAdi," +
                "UyumluIslemciMarkasi," +
                "UyumluSoketTipi," +
                "RamSlotuSayisi," +
                "Bluetooth," +
                "M2SSD," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Marka," +
                "@UrunAdi," +
                "@UyumluIslemciMarkasi," +
                "@UyumluSoketTipi," +
                "@RamSlotuSayisi," +
                "@Bluetooth," +
                "@M2SSD," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox2.Text);
            command.Parameters.AddWithValue("@UrunAdi", textBox3.Text);
            command.Parameters.AddWithValue("@UyumluIslemciMarkasi", textBox4.Text);
            command.Parameters.AddWithValue("@UyumluSoketTipi", textBox5.Text);
            command.Parameters.AddWithValue("@RamSlotuSayisi", textBox6.Text);
            command.Parameters.AddWithValue("@Bluetooth", textBox7.Text);
            command.Parameters.AddWithValue("@M2SSD", textBox8.Text);
            command.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            command.Parameters.AddWithValue("@Stok", textBox10.Text);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddMotherboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPanel form2 = new AddPanel();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
