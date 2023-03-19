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
    public partial class UpdateMotherboard : Form
    {
        public UpdateMotherboard()
        {
            InitializeComponent();
        }

        private void UpdateMotherboard_Load(object sender, EventArgs e)
        {

        }
        //Data Source=DESKTOP-D5NBL2A\\CANDBOKUL;Initial Catalog=ComputerParts;Integrated Security=True
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            
            string updateString = "UPDATE Anakart " +
            "SET " +
            "Marka = @Marka," +
            "UrunAdi=@UrunAdi," +
            "UyumluIslemciMarkasi=@UyumluIslemciMarkasi," +
            "UyumluSoketTipi=@UyumluSoketTipi," +
            "RamSlotuSayisi=@RamSlotuSayisi," +
            "Bluetooth=@Bluetooth," +
            "M2SSD=@M2SSD," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@UrunAdi", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@UyumluIslemciMarkasi", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@UyumluSoketTipi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@RamSlotuSayisi", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@Bluetooth", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@M2SSD", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();

            






            // string sql =("Update Anakart set (" +

            //"Marka," +
            //"UrunAdi," +
            //"UyumluIslemciMarkasi," +
            //"UyumluSoketTipi," +
            //"RamSlotuSayisi," +
            //"Bluetooth," +
            //"M2SSD," +
            //"Fiyat) " +,
            //"WHERE"+
            //"UrunID

            //"VALUES " +
            //"(@UrunID," +
            //"@Marka," +
            //"@UrunAdi," +
            //"@UyumluIslemciMarkasi," +
            //"@UyumluSoketTipi," +
            //"@RamSlotuSayisi," +
            //"@Bluetooth," +
            //"@M2SSD," +
            //"@Fiyat)";
            //command.Parameters.AddWithValue("@username", textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminPanel form2 = new adminPanel();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
