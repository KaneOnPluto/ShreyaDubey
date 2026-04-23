string result = "";

foreach (var item in listBox1.SelectedItems)
{
    result += item.ToString() + " ";
}

string sem = listBox1.Text;
