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
    public partial class updateCPU : Form
    {
        public updateCPU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE Islemci " +
            "SET " +
            "Uretici = @Uretici," +
            "Model=@Model," +
            "UyumluSoket=@UyumluSoket," +
            "MaxFrekansHizi=@MaxFrekansHizi," +
            "CekirdekSayisi=@CekirdekSayisi," +
            "ThreadSayisi=@ThreadSayisi," +
            "TuketimDegeri=@TuketimDegeri," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Uretici", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@Model", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@UyumluSoket", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@MaxFrekansHizi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@CekirdekSayisi", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@ThreadSayisi", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@TuketimDegeri", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();








            // string sql =("Update Islemci set (" +

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
