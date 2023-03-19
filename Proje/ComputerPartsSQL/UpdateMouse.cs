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
    public partial class UpdateMouse : Form
    {
        public UpdateMouse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE Mouse " +
            "SET " +
            "Marka = @Marka," +
            "BaglantiTipi=@BaglantiTipi," +
            "IzlemeTipi=@IzlemeTipi," +
            "TusSayisi=@TusSayisi," +
            "KullanimSekli=@KullanimSekli," +
            "MaxDPI=@MaxDPI," +
            "KablosuzBaglantiTürü=@KablosuzBaglantiTürü," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@BaglantiTipi", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@IzlemeTipi", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@TusSayisi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@KullanimSekli", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@MaxDPI", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@KablosuzBaglantiTürü", textBox8.Text);
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
