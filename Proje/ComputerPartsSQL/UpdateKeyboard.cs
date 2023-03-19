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
    public partial class UpdateKeyboard : Form
    {
        public UpdateKeyboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            string updateString = "UPDATE Klavye " +
            "SET " +
            "MarkaModel = @MarkaModel," +
            "BaglantiTipi=@BaglantiTipi," +
            "Mekanik=@Mekanik," +
            "KlavyeTusDizilimi=@KlavyeTusDizilimi," +
            "SwitchTipi=@SwitchTipi," +
            "KlavyeAydinlatmasi=@KlavyeAydinlatmasi," +
            "Numpad=@Numpad," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@MarkaModel", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@BaglantiTipi", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@Mekanik", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@KlavyeTusDizilimi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@SwitchTipi", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@KlavyeAydinlatmasi", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@Numpad", textBox8.Text);
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

        private void UpdateKeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
