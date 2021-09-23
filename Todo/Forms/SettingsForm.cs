using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todo
{
    public partial class SettingsForm : Form
    {
        mainForm form;
        Size mainFormSize;
        double mainFormOpacity;
        
        public SettingsForm(object sender)
        {
            InitializeComponent();

            // saving main form
            form = sender as mainForm;

            this.TopMost = form.TopMost;

            // load pages
            foreach (object i in form.GetPages())
            {
                if (i.ToString() != "添加新页面")
                {
                    this.defaultPageSelectBox.Items.Add(i);
                }
            }
            this.defaultPageSelectBox.SelectedItem = SettingsManager.GetInstance().Get("default.page");

            // save main form size
            mainFormSize = form.Size;
            this.sizeSelectBoxWidth.Value = form.Size.Width;
            this.sizeSelectBoxHeight.Value = form.Size.Height;

            this.enableSizePreviewCheckBox.Checked = true;

            // save main form opacity
            mainFormOpacity = form.Opacity;
            this.alphaTrackBar.Value = (int)(form.Opacity * 100);

            this.enableAlphaPreviewCheckBox.Checked = true;
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
            form.Opacity = mainFormOpacity;
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // apply changes
            form.Size = new Size((int)this.sizeSelectBoxWidth.Value,
                (int)this.sizeSelectBoxHeight.Value);
            form.Opacity = this.alphaTrackBar.Value / 100.0;

            SettingsManager.GetInstance().Set("default.page", this.defaultPageSelectBox.SelectedItem.ToString())
                .Set("window.size.width", form.Size.Width.ToString())
                .Set("window.size.height", form.Size.Height.ToString())
                .Set("window.opacity", form.Opacity.ToString());
            this.Close();
        }

        private void alphaTrackBar_Scroll(object sender, EventArgs e)
        {
            if (this.enableAlphaPreviewCheckBox.Checked)
            {
                form.Opacity = this.alphaTrackBar.Value / 100.0;
            }
        }
    }
}
