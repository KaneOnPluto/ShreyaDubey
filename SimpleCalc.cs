private void btnAdd_Click(object sender, EventArgs e)
{
    int a = int.Parse(txtA.Text);
    int b = int.Parse(txtB.Text);

    int result = a + b;

    txtResult.Text = result.ToString();
}
