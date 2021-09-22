using System;
using System.Drawing;
using System.Windows.Forms;

namespace Todo
{
    public partial class mainForm : Form
    {
        private string lastPage;
        private bool isDragging = false;
        private Point startPoint;
        private bool enablePageChange = false;
        private string DEFAULT_PAGE = SettingsManager.GetInstance().Get("default.page");

        public mainForm()
        {
            InitializeComponent();
            this.checkedListBox.CheckOnClick = true;

            // load last window position
            Point windowPosition = new Point();
            windowPosition.X = int.Parse(SettingsManager.GetInstance().Get("window.position.x"));
            windowPosition.Y = int.Parse(SettingsManager.GetInstance().Get("window.position.y"));
            this.Location = windowPosition;

            this.enablePageChange = false;

            // load default page
            this.pageSelectBox.SelectedItem = lastPage = DEFAULT_PAGE;
            LoadFromFile(DEFAULT_PAGE + ".dat");

            // load all pages
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

            this.enablePageChange = true;
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
            InputDialog inputDialog = new InputDialog("请输入TODO名称");
            inputDialog.ShowDialog();

            if (inputDialog.DialogResult == DialogResult.OK)
            {   
                foreach (string i in inputDialog.text.Split('\n'))
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

            // save window position
            SettingsManager.GetInstance().Set("window.position.x", this.Location.X.ToString())
                .Set("window.position.y", this.Location.Y.ToString())
            // save all settings
                .Save();
        }

        private void pageSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!enablePageChange)
            {
                return;
            }
            string temp = this.pageSelectBox.SelectedItem as string;
            if (temp == "添加新页面")
            {
                InputDialog dialog = new InputDialog("请输入新页面名称");
                dialog.SetSingleLine();
                dialog.Height = (int)(dialog.Height * 0.4);
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.OK)
                {
                    string name = dialog.text.Trim();
                    if (name != "" && !this.pageSelectBox.Items.Contains(name))
                    {
                        this.pageSelectBox.Items.Insert(this.pageSelectBox.Items.Count - 1, name);
                        this.enablePageChange = false;
                        this.pageSelectBox.SelectedItem = name;
                        this.SaveToFile(lastPage + ".dat");
                        this.LoadFromFile(name + ".dat");
                        lastPage = name;
                        this.enablePageChange = true;
                    }
                }
                else
                {
                    this.enablePageChange = false;
                    this.pageSelectBox.SelectedItem = lastPage;
                    this.LoadFromFile(lastPage + ".dat");
                    this.enablePageChange = true;
                }
            }
            else
            {
                if (lastPage != "添加新页面")
                {
                    this.SaveToFile(lastPage + ".dat");
                }
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

            toolTip.SetToolTip(this.removeButton, "删除此条TODO");
        }

        private void addButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(this.addButton, "添加新TODO");
        }

        private void removePageButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                string toBeDel = this.pageSelectBox.Text;
                if (toBeDel == "默认" || toBeDel == "添加新页面")
                    return;
                this.pageSelectBox.Items.Remove(toBeDel);
                this.pageSelectBox.SelectedItem = DEFAULT_PAGE;
                System.IO.File.Delete("./data/" + toBeDel + ".dat");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point offset = new Point(e.X - startPoint.X, e.Y - startPoint.Y);
                Location = PointToScreen(offset);
            }
        }

        private void titlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void topScreenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.topScreenCheckBox.Checked;
        }
    }
}
