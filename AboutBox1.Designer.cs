﻿namespace universalReader
{
    partial class AboutBox1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelChangeLog = new System.Windows.Forms.Label();
            this.labelBuild = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.ChangeLogBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.95062F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.4321F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.37037F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelChangeLog, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.labelBuild, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 4);
            this.tableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(405, 135);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // labelChangeLog
            // 
            this.labelChangeLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelChangeLog.Location = new System.Drawing.Point(7, 121);
            this.labelChangeLog.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelChangeLog.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelChangeLog.Name = "labelChangeLog";
            this.labelChangeLog.Size = new System.Drawing.Size(167, 14);
            this.labelChangeLog.TabIndex = 23;
            this.labelChangeLog.Text = "Changelog:";
            this.labelChangeLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBuild
            // 
            this.labelBuild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBuild.Location = new System.Drawing.Point(185, 115);
            this.labelBuild.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelBuild.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelBuild.Name = "labelBuild";
            this.labelBuild.Size = new System.Drawing.Size(173, 20);
            this.labelBuild.TabIndex = 0;
            this.labelBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(185, 96);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(173, 19);
            this.labelVersion.TabIndex = 25;
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(185, 76);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(173, 20);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "ProductName";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCompanyName.Location = new System.Drawing.Point(7, 76);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(167, 20);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "ПАО ГК \"ТНС энерго\"";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(7, 96);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(167, 19);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "47 5\'9";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(327, 287);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(88, 27);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&ОК";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // ChangeLogBox
            // 
            this.ChangeLogBox.Location = new System.Drawing.Point(10, 151);
            this.ChangeLogBox.MaxLength = 0;
            this.ChangeLogBox.Multiline = true;
            this.ChangeLogBox.Name = "ChangeLogBox";
            this.ChangeLogBox.ReadOnly = true;
            this.ChangeLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ChangeLogBox.Size = new System.Drawing.Size(405, 130);
            this.ChangeLogBox.TabIndex = 25;
            this.ChangeLogBox.WordWrap = false;
            // 
            // AboutBox1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 327);
            this.Controls.Add(this.ChangeLogBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelBuild;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button okButton;
        private Label labelChangeLog;
        private TextBox ChangeLogBox;
        private PictureBox pictureBox1;
        private Label labelVersion;
    }
}
