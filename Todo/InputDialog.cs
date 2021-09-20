using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class InputDialog : Form
    {
        public string text;
        public InputDialog()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        public InputDialog SetSingleLine()
        {
            this.inputBox.Multiline = false;
            return this;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            text = this.inputBox.Text;
            this.Close();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                this.acceptButton_Click(sender, e);
            }
        }
    }
}
