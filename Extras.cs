// DB 

string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\student.mdf;
Integrated Security=True";

SqlConnection con;
SqlCommand cmd;
SqlDataAdapter da;

public Form1()
{
    InitializeComponent();
    con = new SqlConnection(cs);
}

private void btnSelect_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();

        cmd = new SqlCommand("select * from Students", con);
        da = new SqlDataAdapter(cmd);

        DataTable dt = new DataTable();
        da.Fill(dt);

        dataGridView1.DataSource = dt;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        con.Close();
    }

    private void btnInsert_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();

        string q = "insert into Students values (@Id,@Name,@City)";
        cmd = new SqlCommand(q, con);

        cmd.Parameters.AddWithValue("@Id", txtId.Text);
        cmd.Parameters.AddWithValue("@Name", txtName.Text);
        cmd.Parameters.AddWithValue("@City", cmbCity.Text);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Inserted");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        con.Close();
    }
    }

    private void btnSearch_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();

        cmd = new SqlCommand("select * from Students where Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", txtId.Text);

        da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        dataGridView1.DataSource = dt;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        con.Close();
    }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();

        string q = "update Students set Name=@Name, City=@City where Id=@Id";
        cmd = new SqlCommand(q, con);

        cmd.Parameters.AddWithValue("@Id", txtId.Text);
        cmd.Parameters.AddWithValue("@Name", txtName.Text);
        cmd.Parameters.AddWithValue("@City", cmbCity.Text);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Updated");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        con.Close();
    }
    }

    private void btnDelete_Click(object sender, EventArgs e)
{
    try
    {
        con.Open();

        cmd = new SqlCommand("delete from Students where Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", txtId.Text);

        cmd.ExecuteNonQuery();

        MessageBox.Show("Deleted");
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    finally
    {
        con.Close();
    }
    }
    
}

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

// Arrays / USER inputs / Loops

using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int i = 1;

        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 5);
    }
}

using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 1; i <= 5; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum = " + sum);
    }
}


using System;

class Program
{
    static void Main()
    {
        int n = 5;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elements:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int sum = 0;

        foreach (int i in arr)
        {
            sum += i;
        }

        Console.WriteLine("Sum = " + sum);
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 10, 3, 25, 8 };
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }

        Console.WriteLine("Max = " + max);
    }
}

int min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
}

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        foreach (int i in arr)
            Console.Write(i + " ");
    }
}


using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40 };
        int search = 30;
        bool found = false;

        foreach (int i in arr)
        {
            if (i == search)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Found" : "Not Found");
    }
}



using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int even = 0, odd = 0;

        foreach (int i in arr)
        {
            if (i % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even: " + even);
        Console.WriteLine("Odd: " + odd);
    }
}



using System;

class Program
{
    static void Main()
    {
        int[,] arr = new int[2, 2];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Matrix:");

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

USER INPUT PROBELMS :-


using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine("Sum = " + sum);
    }
}


using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];

            if (arr[i] < min)
                min = arr[i];
        }

        Console.WriteLine("Max = " + max);
        Console.WriteLine("Min = " + min);
    }
}


using System;

class Program
{
    static void Main()
    {
        int n, search;
        bool found = false;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        search = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == search)
            {
                found = true;
                break;
            }
        }

        Console.WriteLine(found ? "Found" : "Not Found");
    }
}


using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Reversed array:");

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Sorting
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array:");

        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int n, even = 0, odd = 0;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

            if (arr[i] % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even = " + even);
        Console.WriteLine("Odd = " + odd);
    }
}

using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Enter size: ");
        n = int.Parse(Console.ReadLine());

        int[] arr1 = new int[n];
        int[] arr2 = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
            arr2[i] = arr1[i];
        }

        Console.WriteLine("Copied array:");

        foreach (int i in arr2)
        {
            Console.Write(i + " ");
        }
    }
}





