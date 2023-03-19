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
    public partial class AddPSU : Form
    {
        public AddPSU()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO PSU (" +
                "UrunID," +
                "Marka," +
                "Model," +
                "Guc," +
                "GucVerimliligi," +
                "Moduler," +
                "AnaKonnektor," +
                "FanSayisi," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Marka," +
                "@Model," +
                "@Guc," +
                "@GucVerimliligi," +
                "@Moduler," +
                "@AnaKonnektor," +
                "@FanSayisi," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox2.Text);
            command.Parameters.AddWithValue("@Model", textBox3.Text);
            command.Parameters.AddWithValue("@Guc", textBox4.Text);
            command.Parameters.AddWithValue("@GucVerimliligi", textBox5.Text);
            command.Parameters.AddWithValue("@Moduler", textBox6.Text);
            command.Parameters.AddWithValue("@AnaKonnektor", textBox7.Text);
            command.Parameters.AddWithValue("@FanSayisi", textBox8.Text);
            command.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            command.Parameters.AddWithValue("@Stok", textBox10.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPanel form2 = new AddPanel();
            form2.Show();
            this.Hide();
        }
    }
}
