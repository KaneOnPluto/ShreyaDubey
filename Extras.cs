// Date time picker

string date = dateTimePicker1.Value.ToString("dd-MM-yyyy");

// File Handling

using System.IO;

File.WriteAllText("data.txt", txtName.Text);
MessageBox.Show("Saved");

// File Reader

string data = File.ReadAllText("data.txt");
txtName.Text = data;

// Open New form

Form2 f = new Form2();
f.Show();

// Login Form

private void btnLogin_Click(object sender, EventArgs e)
{
    if (txtUser.Text == "admin" && txtPass.Text == "123")
    {
        MessageBox.Show("Login Success");
        Form2 f = new Form2();
        f.Show();
    }
    else
    {
        MessageBox.Show("Invalid Login");
    }
}

// Pass Data between forms

// Form 2

public string username;

private void Form2_Load(object sender, EventArgs e)
{
    lblUser.Text = username;
}

// Form 1

Form2 f = new Form2();
f.username = txtUser.Text;
f.Show();

// Timer

private void timer1_Tick(object sender, EventArgs e)
{
    label1.Text = DateTime.Now.ToString();
}

// Change color

this.BackColor = Color.Red;

// Even Odd Check

int n = int.Parse(txtNum.Text);

if (n % 2 == 0)
    MessageBox.Show("Even");
else
    MessageBox.Show("Odd");
