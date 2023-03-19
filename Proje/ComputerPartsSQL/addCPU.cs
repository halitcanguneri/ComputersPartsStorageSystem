﻿using System;
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
    public partial class addCPU : Form
    {
        public addCPU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-C96P3S9\\SQL;Initial Catalog=ComputerPartsStorage;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string sql = "INSERT INTO Islemci (" +
                "UrunID," +
                "Uretici," +
                "Model," +
                "UyumluSoket," +
                "MaxFrekansHizi," +
                "CekirdekSayisi," +
                "ThreadSayisi," +
                "TuketimDegeri," +
                "Fiyat," +
                "Stok) " +

                "VALUES " +
                "(@UrunID," +
                "@Uretici," +
                "@Model," +
                "@UyumluSoket," +
                "@MaxFrekansHizi," +
                "@CekirdekSayisi," +
                "@ThreadSayisi," +
                "@TuketimDegeri," +
                "@Fiyat," +
                "@Stok)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@UrunID", textBox1.Text);
            command.Parameters.AddWithValue("@Uretici", textBox2.Text);
            command.Parameters.AddWithValue("@Model", textBox3.Text);
            command.Parameters.AddWithValue("@UyumluSoket", textBox4.Text);
            command.Parameters.AddWithValue("@MaxFrekansHizi", textBox5.Text);
            command.Parameters.AddWithValue("@CekirdekSayisi", textBox6.Text);
            command.Parameters.AddWithValue("@ThreadSayisi", textBox7.Text);
            command.Parameters.AddWithValue("@TuketimDegeri", textBox8.Text);
            command.Parameters.AddWithValue("@Fiyat", textBox9.Text);
            command.Parameters.AddWithValue("@Stok", textBox10.Text);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addCPU_Load(object sender, EventArgs e)
        {

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
