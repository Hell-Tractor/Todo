
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
            this.label3 = new System.Windows.Forms.Label();
            this.alphaTrackBar = new System.Windows.Forms.TrackBar();
            this.enableAlphaPreviewCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelectBoxHeight)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "默认页面";
            // 
            // defaultPageSelectBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.defaultPageSelectBox, 2);
            this.defaultPageSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultPageSelectBox.FormattingEnabled = true;
            this.defaultPageSelectBox.Location = new System.Drawing.Point(3, 39);
            this.defaultPageSelectBox.Name = "defaultPageSelectBox";
            this.defaultPageSelectBox.Size = new System.Drawing.Size(150, 28);
            this.defaultPageSelectBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 83);
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
            this.enableSizePreviewCheckBox.Location = new System.Drawing.Point(136, 81);
            this.enableSizePreviewCheckBox.Name = "enableSizePreviewCheckBox";
            this.enableSizePreviewCheckBox.Size = new System.Drawing.Size(91, 24);
            this.enableSizePreviewCheckBox.TabIndex = 2;
            this.enableSizePreviewCheckBox.Text = "启用预览";
            this.enableSizePreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizeSelectBoxWidth
            // 
            this.sizeSelectBoxWidth.Location = new System.Drawing.Point(3, 111);
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
            this.sizeSelectBoxHeight.Location = new System.Drawing.Point(136, 111);
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
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.confirmButton, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.alphaTrackBar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.enableAlphaPreviewCheckBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 255);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(19, 221);
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
            this.confirmButton.Location = new System.Drawing.Point(153, 221);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(94, 29);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "确定";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "窗口透明度";
            // 
            // alphaTrackBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.alphaTrackBar, 2);
            this.alphaTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alphaTrackBar.LargeChange = 10;
            this.alphaTrackBar.Location = new System.Drawing.Point(3, 183);
            this.alphaTrackBar.Maximum = 100;
            this.alphaTrackBar.Minimum = 20;
            this.alphaTrackBar.Name = "alphaTrackBar";
            this.alphaTrackBar.Size = new System.Drawing.Size(261, 30);
            this.alphaTrackBar.TabIndex = 8;
            this.alphaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.alphaTrackBar.Value = 20;
            this.alphaTrackBar.Scroll += new System.EventHandler(this.alphaTrackBar_Scroll);
            // 
            // enableAlphaPreviewCheckBox
            // 
            this.enableAlphaPreviewCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.enableAlphaPreviewCheckBox.AutoSize = true;
            this.enableAlphaPreviewCheckBox.Location = new System.Drawing.Point(136, 153);
            this.enableAlphaPreviewCheckBox.Name = "enableAlphaPreviewCheckBox";
            this.enableAlphaPreviewCheckBox.Size = new System.Drawing.Size(91, 24);
            this.enableAlphaPreviewCheckBox.TabIndex = 9;
            this.enableAlphaPreviewCheckBox.Text = "启用预览";
            this.enableAlphaPreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.confirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(267, 255);
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
            ((System.ComponentModel.ISupportInitialize)(this.alphaTrackBar)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar alphaTrackBar;
        private System.Windows.Forms.CheckBox enableAlphaPreviewCheckBox;
    }
}