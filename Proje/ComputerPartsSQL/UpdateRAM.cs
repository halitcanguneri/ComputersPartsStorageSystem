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
    public partial class UpdateRAM : Form
    {
        public UpdateRAM()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE RAM " +
            "SET " +
            "Marka = @Marka," +
            "RamTipi=@RamTipi," +
            "RamKapasitesi=@RamKapasitesi," +
            "FrekansHizi=@FrekansHizi," +
            "VoltajDegeri=@VoltajDegeri," +
            "KanalTipi=@KanalTipi," +
            "Uyumluluk=@Uyumluluk," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@RamTipi", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@RamKapasitesi", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@FrekansHizi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@VoltajDegeri", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@KanalTipi", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@Uyumluluk", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
