
namespace Todo
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.pageSelectBox = new System.Windows.Forms.ComboBox();
            this.removePageButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.settingButton = new System.Windows.Forms.Button();
            this.topScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.checkedListBox = new Todo.TodoListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Controls.Add(this.addButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pageSelectBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.removePageButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.titlePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 442);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(262, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(26, 26);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "＋";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.addButton.MouseHover += new System.EventHandler(this.addButton_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(230, 43);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(26, 26);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            this.removeButton.MouseHover += new System.EventHandler(this.removeButton_MouseHover);
            // 
            // pageSelectBox
            // 
            this.pageSelectBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pageSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pageSelectBox.FormattingEnabled = true;
            this.pageSelectBox.Items.AddRange(new object[] {
            "默认"});
            this.pageSelectBox.Location = new System.Drawing.Point(3, 43);
            this.pageSelectBox.Name = "pageSelectBox";
            this.pageSelectBox.Size = new System.Drawing.Size(151, 28);
            this.pageSelectBox.TabIndex = 3;
            this.pageSelectBox.SelectedIndexChanged += new System.EventHandler(this.pageSelectBox_SelectedIndexChanged);
            // 
            // removePageButton
            // 
            this.removePageButton.Location = new System.Drawing.Point(198, 43);
            this.removePageButton.Name = "removePageButton";
            this.removePageButton.Size = new System.Drawing.Size(26, 26);
            this.removePageButton.TabIndex = 4;
            this.removePageButton.Text = "×";
            this.removePageButton.UseVisualStyleBackColor = true;
            this.removePageButton.Click += new System.EventHandler(this.removePageButton_Click);
            this.removePageButton.MouseHover += new System.EventHandler(this.removePageButton_MouseHover);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.SetColumnSpan(this.titlePanel, 4);
            this.titlePanel.Controls.Add(this.settingButton);
            this.titlePanel.Controls.Add(this.topScreenCheckBox);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlePanel.Location = new System.Drawing.Point(3, 3);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(285, 34);
            this.titlePanel.TabIndex = 5;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseUp);
            // 
            // settingButton
            // 
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Location = new System.Drawing.Point(34, 0);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(40, 34);
            this.settingButton.TabIndex = 2;
            this.settingButton.Text = "⚙";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // topScreenCheckBox
            // 
            this.topScreenCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.topScreenCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.topScreenCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.topScreenCheckBox.FlatAppearance.BorderSize = 0;
            this.topScreenCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.topScreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topScreenCheckBox.Image = global::Todo.Properties.Resources.topScreenCheckBox;
            this.topScreenCheckBox.Location = new System.Drawing.Point(0, 0);
            this.topScreenCheckBox.Name = "topScreenCheckBox";
            this.topScreenCheckBox.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.topScreenCheckBox.Size = new System.Drawing.Size(34, 34);
            this.topScreenCheckBox.TabIndex = 1;
            this.topScreenCheckBox.UseVisualStyleBackColor = true;
            this.topScreenCheckBox.CheckedChanged += new System.EventHandler(this.topScreenCheckBox_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(251, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(34, 34);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "×";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // checkedListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBox, 4);
            this.checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(3, 75);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(285, 364);
            this.checkedListBox.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TODO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox pageSelectBox;
        private System.Windows.Forms.Button removePageButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox topScreenCheckBox;
        private TodoListBox checkedListBox;
        private System.Windows.Forms.Button settingButton;
    }
}

