using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todo
{
    public partial class SettingsForm : Form
    {
        mainForm form;
        Size mainFormSize;
        
        public SettingsForm(object sender)
        {
            InitializeComponent();

            form = sender as mainForm;

            this.TopMost = form.TopMost;

            foreach (object i in form.GetPages())
            {
                if (i.ToString() != "添加新页面")
                {
                    this.defaultPageSelectBox.Items.Add(i);
                }
            }
            this.defaultPageSelectBox.SelectedItem = SettingsManager.GetInstance().Get("default.page");

            mainFormSize = form.Size;
            this.sizeSelectBoxWidth.Value = form.Size.Width;
            this.sizeSelectBoxHeight.Value = form.Size.Height;

            this.enableSizePreviewCheckBox.Checked = true;
        }

        private void sizeSelectBox_ValueChanged(object sender, EventArgs e)
        {
            if (this.enableSizePreviewCheckBox.Checked)
            {
                form.Size = new Size((int)this.sizeSelectBoxWidth.Value,
                    (int)this.sizeSelectBoxHeight.Value);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            form.Size = mainFormSize;
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SettingsManager.GetInstance().Set("default.page", this.defaultPageSelectBox.SelectedItem.ToString())
                .Set("window.size.width", ((int)this.sizeSelectBoxWidth.Value).ToString())
                .Set("window.size.height", ((int)this.sizeSelectBoxHeight.Value).ToString());
            this.Close();
        }
    }
}
