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
    public partial class AddMouse : Form
    {
        public AddMouse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPanel form2 = new AddPanel();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO Mouse (" +
                "UrunID," +
                "Marka," +
                "BaglantiTipi," +
                "IzlemeTipi," +
                "TusSayisi," +
                "KullanimSekli," +
                "MaxDPI," +
                "KablosuzBaglantiTürü," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Marka," +
                "@BaglantiTipi," +
                "@IzlemeTipi," +
                "@TusSayisi," +
                "@KullanimSekli," +
                "@MaxDPI," +
                "@KablosuzBaglantiTürü," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox2.Text);
            command.Parameters.AddWithValue("@BaglantiTipi", textBox3.Text);
            command.Parameters.AddWithValue("@IzlemeTipi", textBox4.Text);
            command.Parameters.AddWithValue("@TusSayisi", textBox5.Text);
            command.Parameters.AddWithValue("@KullanimSekli", textBox6.Text);
            command.Parameters.AddWithValue("@MaxDPI", textBox7.Text);
            command.Parameters.AddWithValue("@KablosuzBaglantiTürü", textBox8.Text);
            command.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            command.Parameters.AddWithValue("@Stok", textBox10.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
