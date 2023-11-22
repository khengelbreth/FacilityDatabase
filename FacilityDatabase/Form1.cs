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
using System.Xml.Linq;

namespace FacilityDatabase
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        private void Form1_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=KRISYOGA;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            cmd = new SqlCommand();
            cmd.Connection = conn;
            MessageBox.Show("connected");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string query = $"insert into Facility values('{textBoxName.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facility";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void cleardata()
        {
            textBoxFacilityNo.Clear();
            textBoxName.Clear();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string query = $"delete Facility where Facility_No='{textBoxFacilityNo.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Facility where Facility_No='" + textBoxSearch.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            textBoxName.Text = dt.ToString();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Facility set Name='" + textBoxName.Text + "' where Facility_No='" + textBoxFacilityNo.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
