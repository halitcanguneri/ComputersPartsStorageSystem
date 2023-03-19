using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace ComputerPartsSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            label5.Text = "Please enter your Username, ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

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

            string sql = "SELECT * FROM Users WHERE username = @username AND password = @password AND user_type = @user_type";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", textBox2.Text);
            command.Parameters.AddWithValue("@user_type", comboBox1.Text);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string userType = reader["user_type"].ToString();
                if (userType == "admin")
                {
                    adminPanel form2 = new adminPanel();
                    form2.Show();
                    this.Hide();
                    
                    // Kullanıcı admin. Admin girişi yapın.
                    Console.WriteLine("admin girişi yapıldı");
                }
                else
                {
                    userPanel form2 = new userPanel();
                    form2.Show();
                    this.Hide();
                    Console.WriteLine("Kullanıcı girişi yapıldı");
                    // Kullanıcı kullanıcı. Kullanıcı girişi yapın.
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı ve parola yanlış");
                label5.Text = "Kullanıcı adı , parola yanlış";
                // Kullanıcı adı ve parola yanlış. Hata mesajı gösterin.
            }

            //if (reader.HasRows)
            //{
            //    Console.WriteLine("giriş başarılı");
            //}
            //else
            //{
            //    Console.WriteLine("username yada password yanlış ");
            //    // Kullanıcı adı ve parola yanlış. Hata mesajı gösterin.
            //}

            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
