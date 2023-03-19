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
    public partial class UpdateMonitor : Form
    {
        public UpdateMonitor()
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

            string updateString = "UPDATE Monitor " +
            "SET " +
            "Marka = @Marka," +
            "Model=@Model," +
            "EkranBoyutu=@EkranBoyutu," +
            "TazelemeHizi=@TazelemeHizi," +
            "GecikmeSuresi=@GecikmeSuresi," +
            "Panel=@Panel," +
            "Hoparlor=@Hoparlor," +
            "Fiyat=@Fiyat," +
            "Stok=@Stok" +

            " WHERE UrunID=@UrunID";

            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.AddWithValue("@UrunID", Convert.ToInt32(textBox1.Text));
            updateCommand.Parameters.AddWithValue("@Marka", textBox2.Text);
            updateCommand.Parameters.AddWithValue("@Model", textBox3.Text);
            updateCommand.Parameters.AddWithValue("@EkranBoyutu", textBox4.Text);
            updateCommand.Parameters.AddWithValue("@TazelemeHizi", textBox5.Text);
            updateCommand.Parameters.AddWithValue("@GecikmeSuresi", textBox6.Text);
            updateCommand.Parameters.AddWithValue("@Panel", textBox7.Text);
            updateCommand.Parameters.AddWithValue("@Hoparlor", textBox8.Text);
            updateCommand.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            updateCommand.Parameters.AddWithValue("@Stok", textBox10.Text);
            connection.Open();
            updateCommand.ExecuteNonQuery();
            connection.Close();

        }
    }
}
