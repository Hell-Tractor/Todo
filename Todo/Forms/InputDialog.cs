using System;
using System.Windows.Forms;

namespace Todo
{
    public partial class InputDialog : Form
    {
        public string text;
        public InputDialog(object sender, string title = "")
        {
            InitializeComponent();

            this.TopMost = (sender as Form).TopMost;

            StartPosition = FormStartPosition.CenterParent;
            this.Text = title;
        }

        public InputDialog SetSingleLine()
        {
            this.inputBox.Multiline = false;
            this.Height = (int)(this.Height * 0.4);
            return this;
        }

        public InputDialog SetText(string text)
        {
            this.inputBox.Text = text;
            return this;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            text = this.inputBox.Text.Trim();
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                text = this.inputBox.Text.Trim();
                this.acceptButton_Click(sender, e);
            }
        }
    }
}
