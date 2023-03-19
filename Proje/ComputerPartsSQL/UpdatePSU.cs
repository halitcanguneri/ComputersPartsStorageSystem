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
    public partial class UpdatePSU : Form
    {
        public UpdatePSU()
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
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE PSU " +
            "SET " +
            "Marka = @Marka," +
            "Model=@Model," +
            "Guc=@Guc," +
            "GucVerimliligi=@GucVerimliligi," +
            "Moduler=@Moduler," +
            "AnaKonnektor=@AnaKonnektor," +
            "FanSayisi=@FanSayisi," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@Model", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@Guc", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@GucVerimliligi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@Moduler", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@AnaKonnektor", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@FanSayisi", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }
    }
}
