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
namespace WFA_DBDemo1
{
public partial class Form1 : Form
{

string cs = @"Data
Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\aarti\documents\visual studio
2015\Projects\WFA-DBDemo1\WFA-DBDemo1\admindemo1.mdf;Integrated Security=True";
SqlCommand cmd;
SqlConnection con;
SqlDataAdapter da;
public Form1()
{
InitializeComponent();
con = new SqlConnection(cs);
}

private void button1_Click(object sender, EventArgs e)
{
try
{
con.Open();
cmd = new SqlCommand("select * from persondata", con);
da = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
da.Fill(dt);
dataGridView1.DataSource = dt;
}
catch (Exception ex)
{
MessageBox.Show("Database connection failed: " + ex.Message);

}
finally
{

if (con.State == ConnectionState.Open)
con.Close();
}
}

private void button2_Click(object sender, EventArgs e)
{
try
{
con.Open();
string id = txtid.Text;
string nm1 = txtnm.Text;

string query = "INSERT INTO persondata" +
"(Id,Name)" +
"VALUES (@id, @nm)";
SqlCommand command = new SqlCommand(query, con);
command.Parameters.AddWithValue("@id", id);
command.Parameters.AddWithValue("@nm", nm1);
command.ExecuteNonQuery();
MessageBox.Show("Record Inserted Sucessfully!!");

}
catch (Exception ex)
{
MessageBox.Show("Database connection failed: " + ex.Message);
}

finally
{
if (con.State == ConnectionState.Open)
con.Close();
}
}

private void update_Click(object sender, EventArgs e)
{
// search button code
//find the updated record .......
//complusary select the entire line from the gridview
int id= int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
string nm = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

txtid.Text = id.ToString();
txtnm.Text = nm;

}

private void updatefinal_Click(object sender, EventArgs e)
{
try
{
con.Open();
string id = txtid.Text;
string nm1 = txtnm.Text;

string query = "UPDATE persondata set Name=@nm where Id=@id";
SqlCommand command = new SqlCommand(query, con);
command.Parameters.AddWithValue("@id", id);

command.Parameters.AddWithValue("@nm", nm1);
command.ExecuteNonQuery();
con.Close();
MessageBox.Show("Record Updated Sucessfully!!");

}
catch(Exception ex)
{
MessageBox.Show("Error in Update : " + ex.Message);
}
}

private void delete_Click(object sender, EventArgs e)
{
int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
string nm = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
string city = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

txtid.Text = id.ToString();
txtnm.Text = nm;
try
{
con.Open();
string query = "DELETE persondata where Id=@id";
SqlCommand command = new SqlCommand(query, con);
command.Parameters.AddWithValue("@id", id);
command.ExecuteNonQuery();
con.Close();
MessageBox.Show("Record deleted Sucessfully!!");

}

catch(Exception ex)
{
MessageBox.Show("Error in delete ... " + ex.Message);
}

}
}
}
