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
    public partial class AddMonitor : Form
    {
        public AddMonitor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO Monitor (" +
                "UrunID," +
                "Marka," +
                "Model," +
                "EkranBoyutu," +
                "TazelemeHizi," +
                "GecikmeSuresi," +
                "Panel," +
                "Hoparlor," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Marka," +
                "@Model," +
                "@EkranBoyutu," +
                "@TazelemeHizi," +
                "@GecikmeSuresi," +
                "@Panel," +
                "@Hoparlor," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Marka", textBox2.Text);
            command.Parameters.AddWithValue("@Model", textBox3.Text);
            command.Parameters.AddWithValue("@EkranBoyutu", textBox4.Text);
            command.Parameters.AddWithValue("@TazelemeHizi", textBox5.Text);
            command.Parameters.AddWithValue("@GecikmeSuresi", textBox6.Text);
            command.Parameters.AddWithValue("@Panel", textBox7.Text);
            command.Parameters.AddWithValue("@Hoparlor", textBox8.Text);
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

        private void AddMonitor_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
