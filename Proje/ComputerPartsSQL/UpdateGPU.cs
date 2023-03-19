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
    public partial class UpdateGPU : Form
    {
        public UpdateGPU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE EkranKarti " +
            "SET " +
            "Marka = @Marka," +
            "UrunSerisi=@UrunSerisi," +
            "UrunModeli=@UrunModeli," +
            "CekirdekHizi=@CekirdekHizi," +
            "BellekTipi=@BellekTipi," +
            "BellekKapasitesi=@BellekKapasitesi," +
            "CudaSayisi=@CudaSayisi," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@UrunSerisi", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@UrunModeli", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@CekirdekHizi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@BellekTipi", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@BellekKapasitesi", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@CudaSayisi", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }
    }
}
