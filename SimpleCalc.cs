private void btnCalc_Click(object sender, EventArgs e)
{
    int a = int.Parse(txtA.Text);
    int b = int.Parse(txtB.Text);
    string op = cmbOp.Text;
    int result = 0;

    switch (op)
    {
        case "+": result = a + b; break;
        case "-": result = a - b; break;
        case "*": result = a * b; break;
        case "/": result = a / b; break;
    }

    txtResult.Text = result.ToString();
}
