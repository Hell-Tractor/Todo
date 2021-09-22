
namespace Todo
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.defaultPageSelectBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enableSizePreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeSelectBoxWidth = new System.Windows.Forms.NumericUpDown();
            this.sizeSelectBoxHeight = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxHeight)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "默认页面";
            // 
            // defaultPageSelectBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.defaultPageSelectBox, 2);
            this.defaultPageSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultPageSelectBox.FormattingEnabled = true;
            this.defaultPageSelectBox.Location = new System.Drawing.Point(3, 41);
            this.defaultPageSelectBox.Name = "defaultPageSelectBox";
            this.defaultPageSelectBox.Size = new System.Drawing.Size(150, 28);
            this.defaultPageSelectBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "窗口大小";
            // 
            // enableSizePreviewCheckBox
            // 
            this.enableSizePreviewCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enableSizePreviewCheckBox.AutoSize = true;
            this.enableSizePreviewCheckBox.Location = new System.Drawing.Point(140, 87);
            this.enableSizePreviewCheckBox.Name = "enableSizePreviewCheckBox";
            this.enableSizePreviewCheckBox.Size = new System.Drawing.Size(91, 24);
            this.enableSizePreviewCheckBox.TabIndex = 2;
            this.enableSizePreviewCheckBox.Text = "启用预览";
            this.enableSizePreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizeSelectBoxWidth
            // 
            this.sizeSelectBoxWidth.Location = new System.Drawing.Point(3, 117);
            this.sizeSelectBoxWidth.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.sizeSelectBoxWidth.Name = "sizeSelectBoxWidth";
            this.sizeSelectBoxWidth.Size = new System.Drawing.Size(112, 27);
            this.sizeSelectBoxWidth.TabIndex = 3;
            this.sizeSelectBoxWidth.ValueChanged += new System.EventHandler(this.sizeSelectBox_ValueChanged);
            // 
            // sizeSelectBoxHeight
            // 
            this.sizeSelectBoxHeight.Location = new System.Drawing.Point(140, 117);
            this.sizeSelectBoxHeight.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.sizeSelectBoxHeight.Name = "sizeSelectBoxHeight";
            this.sizeSelectBoxHeight.Size = new System.Drawing.Size(112, 27);
            this.sizeSelectBoxHeight.TabIndex = 4;
            this.sizeSelectBoxHeight.ValueChanged += new System.EventHandler(this.sizeSelectBox_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sizeSelectBoxHeight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.defaultPageSelectBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sizeSelectBoxWidth, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.enableSizePreviewCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.confirmButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 191);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(21, 157);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(94, 29);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Location = new System.Drawing.Point(158, 157);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 29);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "确定";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(274, 191);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxHeight)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox defaultPageSelectBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox enableSizePreviewCheckBox;
        private System.Windows.Forms.NumericUpDown sizeSelectBoxWidth;
        private System.Windows.Forms.NumericUpDown sizeSelectBoxHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}