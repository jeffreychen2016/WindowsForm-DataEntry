using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryProject
{
    public partial class frmDataEntry : Form
    {
        TimeSpan elapsedTime;
        DateTime lastElapsed;

        public frmDataEntry()
        {
            InitializeComponent();
        }

        private void grbDataEntry_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            timTimer.Enabled = true;
            grbDataEntry.Enabled = true;
            txtName.Focus();
            lastElapsed = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtState.Clear();
            txtZip.Clear();
            txtName.Focus();
        }

        private void timTimer_Tick(object sender, EventArgs e)
        {
            elapsedTime += DateTime.Now - lastElapsed;
            lastElapsed = DateTime.Now;

            txtTimer.Text = Convert.ToString(new TimeSpan(elapsedTime.Hours,elapsedTime.Minutes,elapsedTime.Seconds));
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnPause.Enabled = false;
            grbDataEntry.Enabled = false;
            timTimer.Enabled = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string dataEntry;
            if (txtName.Text.Equals("") || txtAddress.Text.Equals("") || txtCity.Text.Equals("") ||
                txtState.Text.Equals("") || txtZip.Text.Equals(""))
            {
                MessageBox.Show("Please fill in all fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            else
            {
                dataEntry = txtName.Text + "\r\n" + txtAddress.Text + "\r\n" + txtCity.Text + "\r\n" + txtState.Text + "\r\n" + txtZip.Text;
                MessageBox.Show(dataEntry, "Data Entry", MessageBoxButtons.OK);

                // after display the message, clear the form
                btnClear.PerformClick();
            }
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBoxSender = ((TextBox)sender).Name;
            if (e.KeyChar == 13)
            {
                switch (textBoxSender)
                {
                    case "txtName":
                        txtAddress.Focus();
                        break;
                    case "txtAddress":
                        txtCity.Focus();
                        break;
                    case "txtCity":
                        txtState.Focus();
                        break;
                    case "txtState":
                        txtZip.Focus();
                        break;
                    case "txtZip":
                        btnAccept.Focus();
                        break;
                }
            }

            if (textBoxSender.Equals("txtZip"))
            {
                if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
                {
                    // nothing to handle
                    e.Handled = false;
                }
                else
                {
                    // block user from entering anything other than numbers and backspace
                    e.Handled = true;
                }
            }
        }
    }
}
