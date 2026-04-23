// Connection

string conStr = @"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True";

// Code

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUDApp
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=.;Initial Catalog=StudentDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        // Get Gender
        string GetGender()
        {
            if (rbMale.Checked) return "Male";
            else return "Female";
        }

        // Get Hobbies
        string GetHobbies()
        {
            string h = "";
            if (chkReading.Checked) h += "Reading ";
            if (chkDancing.Checked) h += "Dancing ";
            if (chkPlaying.Checked) h += "Playing ";
            return h.Trim();
        }

        // INSERT
        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "INSERT INTO Students VALUES (@Id,@Name,@Gender,@City,@Hobbies,@Semester)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", GetGender());
                cmd.Parameters.AddWithValue("@City", cmbCity.Text);
                cmd.Parameters.AddWithValue("@Hobbies", GetHobbies());
                cmd.Parameters.AddWithValue("@Semester", lstSemester.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted Successfully");
                LoadData();
            }
        }

        // SELECT (LOAD ALL)
        private void btnSelect_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // SEARCH
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM Students WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "UPDATE Students SET Name=@Name, Gender=@Gender, City=@City, Hobbies=@Hobbies, Semester=@Semester WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", GetGender());
                cmd.Parameters.AddWithValue("@City", cmbCity.Text);
                cmd.Parameters.AddWithValue("@Hobbies", GetHobbies());
                cmd.Parameters.AddWithValue("@Semester", lstSemester.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                LoadData();
            }
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "DELETE FROM Students WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
                LoadData();
            }
        }
    }
}
