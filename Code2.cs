Database Adding steps into C#

1. create project
2. prepare desing
3. mIMP--- see the data/verify data
4. create /add the database
5. create tb inside it(desinging tb defination)
6. start coding
a. 1)add namaspaces
b. 2)prepare ConnectionString and others classes of database
c. 3)write code of insert
d. 4)write code of select
e. 5)write code of search for update/delete
f. 6)write code of delete
g. 7)write code of update
7. mImp --- all above operation perfomr through Datagridview

Search Operation

private void Search_Click(object sender, EventArgs e)
{
textBox1.Text = "";
radioButton1.Checked = false;
radioButton2.Checked = false;
checkBox1.Checked = false;
checkBox2.Checked = false;
checkBox3.Checked = false;
comboBox1.SelectedIndex = -1;
listBox1.ClearSelected();

int id=int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
string nm1 = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
string gen = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

string city = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
string hobi = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
string sem = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

textBox1.Text = id.ToString();
textBox2.Text = nm1;
if (gen == "Female")
radioButton1.Checked = true;
else if (gen == "Male")
radioButton2.Checked = true;
else
radioButton1.Checked = true;

for(int i=0;i<comboBox1.Items.Count;i++)
{
if(comboBox1.Items[i].ToString() == city)
{
comboBox1.SelectedIndex = i;
break;
}
}

if (hobi == "Dancing")
checkBox1.Checked = true;
else if (hobi == "Reading")
checkBox2.Checked = true;
else if (hobi == "Playing")
checkBox3.Checked = true;
else

checkBox1.Checked = true;

for (int i = 0; i < listBox1.Items.Count; i++)
{
if (listBox1.Items[i].ToString() == sem)
{
listBox1.SelectedIndex = i;
break;
}
}
}
