﻿namespace dataEditor
{
    partial class hoursZoneEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoursZoneEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("0");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("с", new System.Windows.Forms.TreeNode[] {
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("0");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("до", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("день", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("0");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("с", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("0");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("до", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("ночь", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("пик");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("полупик");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("ночь");
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnConfirm = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.typeList = new System.Windows.Forms.ToolStripComboBox();
            this.hoursDataGrid = new dataEditor.MainForm.DoubleBufferedDataGridView();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDoubleZone = new System.Windows.Forms.GroupBox();
            this.DoubleZTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.doubleZoneTreeView = new System.Windows.Forms.TreeView();
            this.groupTrippleZone = new System.Windows.Forms.GroupBox();
            this.TrippleZTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.trippleZoneTreeView = new System.Windows.Forms.TreeView();
            this.zoneToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAddNew3z = new System.Windows.Forms.ToolStripButton();
            this.cmbxSelectTypeZone = new System.Windows.Forms.ToolStripComboBox();
            this.groupHours = new System.Windows.Forms.GroupBox();
            this.HoursTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnApplyHours = new System.Windows.Forms.Button();
            this.cmbxSelectGlobalZone = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).BeginInit();
            this.groupDoubleZone.SuspendLayout();
            this.DoubleZTableLayout.SuspendLayout();
            this.groupTrippleZone.SuspendLayout();
            this.TrippleZTableLayout.SuspendLayout();
            this.zoneToolStrip.SuspendLayout();
            this.groupHours.SuspendLayout();
            this.HoursTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfirm,
            this.btnSave,
            this.btnSaveAll,
            this.toolStripSeparator7,
            this.typeList});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(10, 2, 1, 2);
            this.ToolStrip.Size = new System.Drawing.Size(151, 28);
            this.ToolStrip.TabIndex = 81;
            this.ToolStrip.Text = "mgTools";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfirm.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirm.Image")));
            this.btnConfirm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(23, 22);
            this.btnConfirm.Text = "Enter";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 21);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAll.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.Image")));
            this.btnSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(23, 21);
            this.btnSaveAll.Text = "Сохранить все";
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 24);
            // 
            // typeList
            // 
            this.typeList.AutoSize = false;
            this.typeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.typeList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeList.Items.AddRange(new object[] {
            "ФЛ",
            "ЮЛ"});
            this.typeList.Margin = new System.Windows.Forms.Padding(1);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(60, 22);
            this.typeList.DropDownClosed += new System.EventHandler(this.typeList_DropDownClosed);
            // 
            // hoursDataGrid
            // 
            this.hoursDataGrid.AllowUserToAddRows = false;
            this.hoursDataGrid.AllowUserToDeleteRows = false;
            this.hoursDataGrid.AllowUserToResizeColumns = false;
            this.hoursDataGrid.AllowUserToResizeRows = false;
            this.hoursDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoursDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hoursDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hoursDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hoursDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.hoursDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoursDataGrid.ColumnHeadersVisible = false;
            this.hoursDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hours});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hoursDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.hoursDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this.hoursDataGrid.Location = new System.Drawing.Point(2, 57);
            this.hoursDataGrid.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.hoursDataGrid.Name = "hoursDataGrid";
            this.hoursDataGrid.ReadOnly = true;
            this.hoursDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.hoursDataGrid.RowHeadersVisible = false;
            this.hoursDataGrid.RowTemplate.Height = 15;
            this.hoursDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hoursDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hoursDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hoursDataGrid.Size = new System.Drawing.Size(105, 365);
            this.hoursDataGrid.TabIndex = 82;
            this.hoursDataGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.hoursDataGrid_Paint);
            this.hoursDataGrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hoursDataGrid_MouseMove);
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            // 
            // groupDoubleZone
            // 
            this.groupDoubleZone.Controls.Add(this.DoubleZTableLayout);
            this.groupDoubleZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupDoubleZone.Location = new System.Drawing.Point(137, 34);
            this.groupDoubleZone.Name = "groupDoubleZone";
            this.groupDoubleZone.Size = new System.Drawing.Size(180, 475);
            this.groupDoubleZone.TabIndex = 83;
            this.groupDoubleZone.TabStop = false;
            this.groupDoubleZone.Text = "2 зоны";
            // 
            // DoubleZTableLayout
            // 
            this.DoubleZTableLayout.ColumnCount = 1;
            this.DoubleZTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoubleZTableLayout.Controls.Add(this.doubleZoneTreeView, 0, 1);
            this.DoubleZTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoubleZTableLayout.Location = new System.Drawing.Point(3, 18);
            this.DoubleZTableLayout.Name = "DoubleZTableLayout";
            this.DoubleZTableLayout.RowCount = 2;
            this.DoubleZTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DoubleZTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoubleZTableLayout.Size = new System.Drawing.Size(174, 454);
            this.DoubleZTableLayout.TabIndex = 87;
            // 
            // doubleZoneTreeView
            // 
            this.doubleZoneTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doubleZoneTreeView.ItemHeight = 15;
            this.doubleZoneTreeView.Location = new System.Drawing.Point(3, 3);
            this.doubleZoneTreeView.Name = "doubleZoneTreeView";
            treeNode27.Name = "initialVal";
            treeNode27.NodeFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode27.Text = "0";
            treeNode28.Name = "initial";
            treeNode28.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode28.Text = "с";
            treeNode29.Name = "finalVal";
            treeNode29.NodeFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode29.Text = "0";
            treeNode30.Name = "final";
            treeNode30.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode30.Text = "до";
            treeNode31.Name = "day";
            treeNode31.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode31.Text = "день";
            treeNode32.Name = "initialVal";
            treeNode32.NodeFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode32.Text = "0";
            treeNode33.Name = "initial";
            treeNode33.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode33.Text = "с";
            treeNode34.Name = "finalVal";
            treeNode34.NodeFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode34.Text = "0";
            treeNode35.Name = "final";
            treeNode35.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode35.Text = "до";
            treeNode36.Name = "night";
            treeNode36.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode36.Text = "ночь";
            this.doubleZoneTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode36});
            this.doubleZoneTreeView.Size = new System.Drawing.Size(168, 448);
            this.doubleZoneTreeView.TabIndex = 0;
            this.doubleZoneTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.doubleZoneTreeView_AfterSelect);
            this.doubleZoneTreeView.Enter += new System.EventHandler(this.doubleZoneTreeView_Enter);
            // 
            // groupTrippleZone
            // 
            this.groupTrippleZone.Controls.Add(this.TrippleZTableLayout);
            this.groupTrippleZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupTrippleZone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupTrippleZone.Location = new System.Drawing.Point(323, 34);
            this.groupTrippleZone.Name = "groupTrippleZone";
            this.groupTrippleZone.Size = new System.Drawing.Size(200, 475);
            this.groupTrippleZone.TabIndex = 84;
            this.groupTrippleZone.TabStop = false;
            this.groupTrippleZone.Text = "3 зоны";
            // 
            // TrippleZTableLayout
            // 
            this.TrippleZTableLayout.ColumnCount = 1;
            this.TrippleZTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrippleZTableLayout.Controls.Add(this.trippleZoneTreeView, 0, 1);
            this.TrippleZTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrippleZTableLayout.Location = new System.Drawing.Point(3, 18);
            this.TrippleZTableLayout.Name = "TrippleZTableLayout";
            this.TrippleZTableLayout.RowCount = 2;
            this.TrippleZTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TrippleZTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TrippleZTableLayout.Size = new System.Drawing.Size(194, 454);
            this.TrippleZTableLayout.TabIndex = 86;
            // 
            // trippleZoneTreeView
            // 
            this.trippleZoneTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trippleZoneTreeView.ItemHeight = 15;
            this.trippleZoneTreeView.Location = new System.Drawing.Point(3, 3);
            this.trippleZoneTreeView.Name = "trippleZoneTreeView";
            treeNode37.Name = "peak";
            treeNode37.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode37.Text = "пик";
            treeNode38.Name = "semiPeak";
            treeNode38.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode38.Text = "полупик";
            treeNode39.Name = "night";
            treeNode39.NodeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode39.Text = "ночь";
            this.trippleZoneTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            this.trippleZoneTreeView.Size = new System.Drawing.Size(188, 448);
            this.trippleZoneTreeView.TabIndex = 1;
            this.trippleZoneTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrippleZoneTreeView_AfterSelect);
            this.trippleZoneTreeView.Enter += new System.EventHandler(this.TrippleZoneTreeView_Enter);
            // 
            // zoneToolStrip
            // 
            this.zoneToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoneToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.zoneToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNew3z,
            this.cmbxSelectTypeZone});
            this.zoneToolStrip.Location = new System.Drawing.Point(1, 29);
            this.zoneToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.zoneToolStrip.Name = "zoneToolStrip";
            this.zoneToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.zoneToolStrip.Size = new System.Drawing.Size(107, 26);
            this.zoneToolStrip.TabIndex = 85;
            this.zoneToolStrip.Text = "mgTools";
            // 
            // btnAddNew3z
            // 
            this.btnAddNew3z.AutoToolTip = false;
            this.btnAddNew3z.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddNew3z.Enabled = false;
            this.btnAddNew3z.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNew3z.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew3z.Image")));
            this.btnAddNew3z.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew3z.Name = "btnAddNew3z";
            this.btnAddNew3z.Size = new System.Drawing.Size(23, 21);
            this.btnAddNew3z.Text = "Add";
            this.btnAddNew3z.Click += new System.EventHandler(this.btnAddNew3z_Click);
            // 
            // cmbxSelectTypeZone
            // 
            this.cmbxSelectTypeZone.AutoSize = false;
            this.cmbxSelectTypeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectTypeZone.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbxSelectTypeZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxSelectTypeZone.Margin = new System.Windows.Forms.Padding(1);
            this.cmbxSelectTypeZone.Name = "cmbxSelectTypeZone";
            this.cmbxSelectTypeZone.Size = new System.Drawing.Size(80, 22);
            this.cmbxSelectTypeZone.DropDownClosed += new System.EventHandler(this.cmbxSelectTypeZone_DropDownClosed);
            // 
            // groupHours
            // 
            this.groupHours.Controls.Add(this.HoursTableLayoutPanel);
            this.groupHours.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupHours.Location = new System.Drawing.Point(12, 34);
            this.groupHours.Name = "groupHours";
            this.groupHours.Size = new System.Drawing.Size(115, 475);
            this.groupHours.TabIndex = 85;
            this.groupHours.TabStop = false;
            this.groupHours.Text = "Часы";
            // 
            // HoursTableLayoutPanel
            // 
            this.HoursTableLayoutPanel.ColumnCount = 1;
            this.HoursTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HoursTableLayoutPanel.Controls.Add(this.btnApplyHours, 0, 3);
            this.HoursTableLayoutPanel.Controls.Add(this.zoneToolStrip, 0, 1);
            this.HoursTableLayoutPanel.Controls.Add(this.hoursDataGrid, 0, 2);
            this.HoursTableLayoutPanel.Controls.Add(this.cmbxSelectGlobalZone, 0, 0);
            this.HoursTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoursTableLayoutPanel.Location = new System.Drawing.Point(3, 18);
            this.HoursTableLayoutPanel.Name = "HoursTableLayoutPanel";
            this.HoursTableLayoutPanel.RowCount = 4;
            this.HoursTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HoursTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HoursTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HoursTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HoursTableLayoutPanel.Size = new System.Drawing.Size(109, 454);
            this.HoursTableLayoutPanel.TabIndex = 83;
            // 
            // btnApplyHours
            // 
            this.btnApplyHours.Location = new System.Drawing.Point(3, 426);
            this.btnApplyHours.Name = "btnApplyHours";
            this.btnApplyHours.Size = new System.Drawing.Size(103, 25);
            this.btnApplyHours.TabIndex = 83;
            this.btnApplyHours.Text = "Применить";
            this.btnApplyHours.UseVisualStyleBackColor = true;
            this.btnApplyHours.Click += new System.EventHandler(this.btnApplyHours_Click);
            // 
            // cmbxSelectGlobalZone
            // 
            this.cmbxSelectGlobalZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbxSelectGlobalZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectGlobalZone.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbxSelectGlobalZone.FormattingEnabled = true;
            this.cmbxSelectGlobalZone.Items.AddRange(new object[] {
            "2 зоны",
            "3 зоны"});
            this.cmbxSelectGlobalZone.Location = new System.Drawing.Point(3, 3);
            this.cmbxSelectGlobalZone.Name = "cmbxSelectGlobalZone";
            this.cmbxSelectGlobalZone.Size = new System.Drawing.Size(103, 22);
            this.cmbxSelectGlobalZone.TabIndex = 84;
            this.cmbxSelectGlobalZone.DropDownClosed += new System.EventHandler(this.cmbxSelectGlobalZone_DropDownClosed);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // hoursZoneEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 518);
            this.Controls.Add(this.groupTrippleZone);
            this.Controls.Add(this.groupHours);
            this.Controls.Add(this.groupDoubleZone);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "hoursZoneEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hoursZoneEditor";
            this.Load += new System.EventHandler(this.hoursZoneEditor_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursDataGrid)).EndInit();
            this.groupDoubleZone.ResumeLayout(false);
            this.DoubleZTableLayout.ResumeLayout(false);
            this.groupTrippleZone.ResumeLayout(false);
            this.TrippleZTableLayout.ResumeLayout(false);
            this.zoneToolStrip.ResumeLayout(false);
            this.zoneToolStrip.PerformLayout();
            this.groupHours.ResumeLayout(false);
            this.HoursTableLayoutPanel.ResumeLayout(false);
            this.HoursTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip ToolStrip;
        private ToolStripSeparator toolStripSeparator7;
        private dataEditor.MainForm.DoubleBufferedDataGridView hoursDataGrid;
        private DataGridViewTextBoxColumn Hours;
        private GroupBox groupDoubleZone;
        private TreeView doubleZoneTreeView;
        private GroupBox groupTrippleZone;
        private TreeView trippleZoneTreeView;
        private GroupBox groupHours;
        private TableLayoutPanel DoubleZTableLayout;
        private TableLayoutPanel TrippleZTableLayout;
        private ToolStrip zoneToolStrip;
        private ToolStripButton btnAddNew3z;
        private TableLayoutPanel HoursTableLayoutPanel;
        private Button btnApplyHours;
        private ComboBox cmbxSelectGlobalZone;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox cmbxSelectTypeZone;
        private ToolStripComboBox typeList;
        private ToolStripButton btnSave;
        private ToolStripButton btnSaveAll;
        private ToolStripButton btnConfirm;
    }
}