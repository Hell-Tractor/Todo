using System;
using System.Windows.Forms;

namespace Todo
{
    public partial class mainForm : Form
    {
        private string lastPage;
        public mainForm()
        {
            InitializeComponent();
            this.checkedListBox.CheckOnClick = true;
            this.pageSelectBox.SelectedItem = lastPage = "默认";
            LoadFromFile("默认.dat");

            System.IO.DirectoryInfo info = new System.IO.DirectoryInfo("./data");
            foreach (var temp in info.GetFiles("*.dat"))
            {
                string pageName = temp.Name.Split('.')[0];
                if (!this.pageSelectBox.Items.Contains(pageName))
                {
                    this.pageSelectBox.Items.Add(pageName);
                }
            }
            this.pageSelectBox.Items.Add("添加新页面");
        }

        private void SaveToFile(string filename)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("./data/" + filename))
            {
                for (int i = 0; i < this.checkedListBox.Items.Count; ++i)
                {
                    writer.WriteLine(this.checkedListBox.GetItemChecked(i).ToString() + " " + 
                        this.checkedListBox.Items[i]);
                }
            }
        }

        private void LoadFromFile(string filename)
        {
            this.checkedListBox.Items.Clear();

            if (!System.IO.File.Exists("./data/" + filename))
                return;

            using (System.IO.StreamReader reader = new System.IO.StreamReader("./data/" + filename))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] temp = line.Split();
                    bool state = temp[0] == "True";
                    this.checkedListBox.Items.Add(temp[1], state);
                }
            }
        }
        //
        // Events
        //
        private void addButton_Click(object sender, EventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            inputDialog.ShowDialog();

            if (inputDialog.DialogResult == DialogResult.OK)
            {   
                foreach (string i in inputDialog.text.Trim().Split('\n'))
                {
                    string temp = i.Trim();
                    if (temp != "" && !this.checkedListBox.Items.Contains(temp))
                    {
                        this.checkedListBox.Items.Add(temp);
                    }
                }
            }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                this.addButton_Click(sender, e);
                e.Handled = true;
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                this.removeButton_Click(sender, e);
                e.Handled = true;
                return;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.checkedListBox.Items.Remove(this.checkedListBox.SelectedItem);
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToFile((this.pageSelectBox.SelectedItem as string) + ".dat");
        }

        private void pageSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = this.pageSelectBox.SelectedItem as string;
            if (temp == "添加新页面")
            {
                InputDialog dialog = new InputDialog();
                dialog.SetSingleLine();
                dialog.Height = (int)(dialog.Height * 0.4);
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {
                    string name = dialog.text.Trim();
                    if (name != "" && !this.pageSelectBox.Items.Contains(name))
                    {
                        this.pageSelectBox.Items.Insert(this.pageSelectBox.Items.Count - 1, name);
                        this.pageSelectBox.SelectedItem = name;
                    }
                }
            }
            else
            {
                this.SaveToFile(lastPage + ".dat");
                this.LoadFromFile(temp + ".dat");
                lastPage = temp;
            }
        }

        private void removePageButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.removePageButton, "删除此页");
        }

        private void removeButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.removePageButton, "删除此条TODO");
        }

        private void addButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.removePageButton, "添加新TODO");
        }

        private void removePageButton_Click(object sender, EventArgs e)
        {
            string toBeDel = this.pageSelectBox.Text;
            if (toBeDel == "默认" || toBeDel == "添加新页面")
                return;
            this.pageSelectBox.Items.Remove(toBeDel);
            this.pageSelectBox.SelectedItem = "默认";
            System.IO.File.Delete("./data/" + toBeDel + ".dat");
        }
    }
}
