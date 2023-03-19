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
    public partial class AddKeyboard : Form
    {
        public AddKeyboard()
        {
            InitializeComponent();
        }

        private void Brand_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO Klavye (" +
                "UrunID," +
                "MarkaModel," +
                "BaglantiTipi," +
                "Mekanik," +
                "KlavyeTusDizilimi," +
                "SwitchTipi," +
                "KlavyeAydinlatmasi," +
                "Numpad," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@MarkaModel," +
                "@BaglantiTipi," +
                "@Mekanik," +
                "@KlavyeTusDizilimi," +
                "@SwitchTipi," +
                "@KlavyeAydinlatmasi," +
                "@Numpad," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@MarkaModel", textBox2.Text);
            command.Parameters.AddWithValue("@BaglantiTipi", textBox3.Text);
            command.Parameters.AddWithValue("@Mekanik", textBox4.Text);
            command.Parameters.AddWithValue("@KlavyeTusDizilimi", textBox5.Text);
            command.Parameters.AddWithValue("@SwitchTipi", textBox6.Text);
            command.Parameters.AddWithValue("@KlavyeAydinlatmasi", textBox7.Text);
            command.Parameters.AddWithValue("@Numpad", textBox8.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AddKeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
