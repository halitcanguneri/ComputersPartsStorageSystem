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
    public partial class AddRAM : Form
    {
        public AddRAM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO RAM (" +
                "UrunID," +
                "Marka," +
                "RamTipi," +
                "RamKapasitesi," +
                "FrekansHizi," +
                "VoltajDegeri," +
                "KanalTipi," +
                "Uyumluluk," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Marka," +
                "@RamTipi," +
                "@RamKapasitesi," +
                "@FrekansHizi," +
                "@VoltajDegeri," +
                "@KanalTipi," +
                "@Uyumluluk," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox2.Text);
            command.Parameters.AddWithValue("@RamTipi", textBox3.Text);
            command.Parameters.AddWithValue("@RamKapasitesi", textBox4.Text);
            command.Parameters.AddWithValue("@FrekansHizi", textBox5.Text);
            command.Parameters.AddWithValue("@VoltajDegeri", textBox6.Text);
            command.Parameters.AddWithValue("@KanalTipi", textBox7.Text);
            command.Parameters.AddWithValue("@Uyumluluk", textBox8.Text);
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
