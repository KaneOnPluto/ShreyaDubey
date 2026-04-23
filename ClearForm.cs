void ClearForm()
{
    txtId.Clear();
    txtName.Clear();
    cmbCity.SelectedIndex = -1;

    rbMale.Checked = false;
    rbFemale.Checked = false;

    chkReading.Checked = false;
    chkDancing.Checked = false;
    chkPlaying.Checked = false;
}
