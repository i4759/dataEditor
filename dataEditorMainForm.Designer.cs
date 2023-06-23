﻿using System.Reflection;
using System.Windows.Forms;
using universalReader;
using static dataEditor.Program;

namespace dataEditor
{
    partial class MainForm
    {

        private System.ComponentModel.IContainer components = null;


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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Коэффициент оплаты мощности потребителями (покупателями), осуществляющими расчеты" +
        " по 1ЦК, 1/час", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Средневзвешенная нерегулируемая цена на мощность на оптовом рынке, руб/МВт", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Средневзвешенная нерегулируемая цена на электрическую энергию на оптовом рынке, о" +
        "пределяемая по результатам конкурентных отборов на сутки вперед, руб/МВтч", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ночная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("полупиковая зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("пиковая зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode(resources.GetString("datsTreeView.Nodes"), new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("ночная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("дневная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode(resources.GetString("datsTreeView.Nodes1"), new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ночная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("полупиковая зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("пиковая зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Коэффициент оплаты мощности для соответствующих зон суток (три зоны суток)", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode22,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("ночная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("null");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("дневная зона суток", new System.Windows.Forms.TreeNode[] {
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Коэффициент оплаты мощности для соответствующих зон суток (две зоны суток)", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode29});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RowContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightClick_HeadsRow = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClick_FirstRowData = new System.Windows.Forms.ToolStripMenuItem();
            this.propGrid_stripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CellContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsStaticValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsColumn4CheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitUR = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllExcelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regLibOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universalReaderToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xFAReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabMicrogeneration = new System.Windows.Forms.TabPage();
            this.g = new System.Windows.Forms.ToolStrip();
            this.mgBtnNewProject = new System.Windows.Forms.ToolStripButton();
            this.mgBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.mgBtnSaveDats = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mgBtnImportFile = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnConvertFile = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDictionaryList = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDictionaryEditor = new System.Windows.Forms.ToolStripButton();
            this.mgBtnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnMounth = new System.Windows.Forms.ToolStripComboBox();
            this.toolBtnYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.mgOpenDataTable = new System.Windows.Forms.ToolStripButton();
            this.mgDataСalculation = new System.Windows.Forms.ToolStripButton();
            this.mgDataAct = new System.Windows.Forms.ToolStripButton();
            this.mgSplitContainer_vertical = new System.Windows.Forms.SplitContainer();
            this.mgSplitContainer_horizontal = new System.Windows.Forms.SplitContainer();
            this.upperTableLayoutMainData = new System.Windows.Forms.TableLayoutPanel();
            this.lblMainName = new System.Windows.Forms.Label();
            this.textBoxNameGP = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.textBoxGTPcode = new System.Windows.Forms.TextBox();
            this.lblNameGP = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.lblGTPcode = new System.Windows.Forms.Label();
            this.tabControlCurrentProject = new System.Windows.Forms.TabControl();
            this.tabBasic = new System.Windows.Forms.TabPage();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.mgSplitContainer_insideHorizontal = new System.Windows.Forms.SplitContainer();
            this.mgSplitContainer_inside_vertical = new System.Windows.Forms.SplitContainer();
            this.mgDataViewer = new dataEditor.MainForm.DoubleBufferedDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agreement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAgreement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TariffZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCalculation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgSplitContainer_insideRight = new System.Windows.Forms.SplitContainer();
            this.groupBoxRes = new System.Windows.Forms.GroupBox();
            this.ResourcesTreeView = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.mgFlowPanelResult = new System.Windows.Forms.FlowLayoutPanel();
            this.inputTableLoyaut = new System.Windows.Forms.TableLayoutPanel();
            this.datsTreeView = new System.Windows.Forms.TreeView();
            this.mgToolStripInputData = new System.Windows.Forms.ToolStrip();
            this.mgBtnEntryDatFiles = new System.Windows.Forms.ToolStripSplitButton();
            this.mgFileSPUNC = new System.Windows.Forms.ToolStripMenuItem();
            this.mgFileSVNC = new System.Windows.Forms.ToolStripMenuItem();
            this.mgFileKF = new System.Windows.Forms.ToolStripMenuItem();
            this.mgFileSPUNCbtn = new System.Windows.Forms.ToolStripButton();
            this.mgFileSVNCbtn = new System.Windows.Forms.ToolStripButton();
            this.mgFileKFbtn = new System.Windows.Forms.ToolStripButton();
            this.imgStatusOk = new System.Windows.Forms.ToolStripButton();
            this.imgStatusDwnld = new System.Windows.Forms.ToolStripButton();
            this.imgStatusFailed = new System.Windows.Forms.ToolStripButton();
            this.appInfo = new System.Windows.Forms.Label();
            this.tabExcel = new System.Windows.Forms.TabPage();
            this.urToolStrip = new System.Windows.Forms.ToolStrip();
            this.urBtnImportFile = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.urBtnSaveXML = new System.Windows.Forms.ToolStripButton();
            this.urBtnConvert2Tree = new System.Windows.Forms.ToolStripButton();
            this.splitContainer_bigMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer_dataGrids = new System.Windows.Forms.SplitContainer();
            this.CellViewer = new System.Windows.Forms.TextBox();
            this.dataViewer = new dataEditor.MainForm.DoubleBufferedDataGridView();
            this.splitContainer_rightProps = new System.Windows.Forms.SplitContainer();
            this.statusGridView = new dataEditor.MainForm.StatusGridViewEditMode();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urOptionsGrid = new System.Windows.Forms.PropertyGrid();
            this.SectionsControl = new System.Windows.Forms.TabControl();
            this.buttonBackground = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuOpenTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imgListData = new System.Windows.Forms.ImageList(this.components);
            this.RowContext.SuspendLayout();
            this.propGrid_stripMenu.SuspendLayout();
            this.CellContext.SuspendLayout();
            this.ColumnContext.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabMicrogeneration.SuspendLayout();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_vertical)).BeginInit();
            this.mgSplitContainer_vertical.Panel2.SuspendLayout();
            this.mgSplitContainer_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_horizontal)).BeginInit();
            this.mgSplitContainer_horizontal.Panel1.SuspendLayout();
            this.mgSplitContainer_horizontal.Panel2.SuspendLayout();
            this.mgSplitContainer_horizontal.SuspendLayout();
            this.upperTableLayoutMainData.SuspendLayout();
            this.tabControlCurrentProject.SuspendLayout();
            this.tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_insideHorizontal)).BeginInit();
            this.mgSplitContainer_insideHorizontal.Panel1.SuspendLayout();
            this.mgSplitContainer_insideHorizontal.Panel2.SuspendLayout();
            this.mgSplitContainer_insideHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_inside_vertical)).BeginInit();
            this.mgSplitContainer_inside_vertical.Panel1.SuspendLayout();
            this.mgSplitContainer_inside_vertical.Panel2.SuspendLayout();
            this.mgSplitContainer_inside_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgDataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_insideRight)).BeginInit();
            this.mgSplitContainer_insideRight.Panel1.SuspendLayout();
            this.mgSplitContainer_insideRight.Panel2.SuspendLayout();
            this.mgSplitContainer_insideRight.SuspendLayout();
            this.groupBoxRes.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            this.inputTableLoyaut.SuspendLayout();
            this.mgToolStripInputData.SuspendLayout();
            this.tabExcel.SuspendLayout();
            this.urToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_bigMain)).BeginInit();
            this.splitContainer_bigMain.Panel1.SuspendLayout();
            this.splitContainer_bigMain.Panel2.SuspendLayout();
            this.splitContainer_bigMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataGrids)).BeginInit();
            this.splitContainer_dataGrids.Panel1.SuspendLayout();
            this.splitContainer_dataGrids.Panel2.SuspendLayout();
            this.splitContainer_dataGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rightProps)).BeginInit();
            this.splitContainer_rightProps.Panel1.SuspendLayout();
            this.splitContainer_rightProps.Panel2.SuspendLayout();
            this.splitContainer_rightProps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusGridView)).BeginInit();
            this.SectionsControl.SuspendLayout();
            this.buttonBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowContext
            // 
            this.RowContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RowContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightClick_HeadsRow,
            this.RightClick_FirstRowData});
            this.RowContext.Name = "contextDataViewer";
            this.RowContext.Size = new System.Drawing.Size(177, 48);
            // 
            // RightClick_HeadsRow
            // 
            this.RightClick_HeadsRow.Name = "RightClick_HeadsRow";
            this.RightClick_HeadsRow.Size = new System.Drawing.Size(176, 22);
            this.RightClick_HeadsRow.Text = "Set as HeadsRow";
            this.RightClick_HeadsRow.Click += new System.EventHandler(this.StripMenuHeaderRow_Click);
            // 
            // RightClick_FirstRowData
            // 
            this.RightClick_FirstRowData.Name = "RightClick_FirstRowData";
            this.RightClick_FirstRowData.Size = new System.Drawing.Size(176, 22);
            this.RightClick_FirstRowData.Text = "Set as FirstDataRow";
            this.RightClick_FirstRowData.Click += new System.EventHandler(this.StripMenuFirstData_Click);
            // 
            // propGrid_stripMenu
            // 
            this.propGrid_stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.propGrid_stripMenu.Name = "propGrid_stripMenu";
            this.propGrid_stripMenu.Size = new System.Drawing.Size(100, 26);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.propGrid_stripHelp);
            // 
            // CellContext
            // 
            this.CellContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CellContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsStaticValueToolStripMenuItem});
            this.CellContext.Name = "RowContext";
            this.CellContext.Size = new System.Drawing.Size(170, 26);
            // 
            // setAsStaticValueToolStripMenuItem
            // 
            this.setAsStaticValueToolStripMenuItem.Name = "setAsStaticValueToolStripMenuItem";
            this.setAsStaticValueToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.setAsStaticValueToolStripMenuItem.Text = "Set As Static Value";
            // 
            // ColumnContext
            // 
            this.ColumnContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ColumnContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsColumn4CheckToolStripMenuItem});
            this.ColumnContext.Name = "ColumnContext";
            this.ColumnContext.Size = new System.Drawing.Size(190, 26);
            // 
            // setAsColumn4CheckToolStripMenuItem
            // 
            this.setAsColumn4CheckToolStripMenuItem.Name = "setAsColumn4CheckToolStripMenuItem";
            this.setAsColumn4CheckToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setAsColumn4CheckToolStripMenuItem.Text = "Set as Column4Check";
            this.setAsColumn4CheckToolStripMenuItem.Click += new System.EventHandler(this.StripMenuHeaderColumnSelect_Click);
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXMLToolStripMenuItem,
            this.ExitUR});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(36, 20);
            this.FileMenu.Text = "File";
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.import2Universal_Click);
            // 
            // ExitUR
            // 
            this.ExitUR.Image = ((System.Drawing.Image)(resources.GetObject("ExitUR.Image")));
            this.ExitUR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ExitUR.Name = "ExitUR";
            this.ExitUR.Size = new System.Drawing.Size(137, 22);
            this.ExitUR.Text = "Exit";
            this.ExitUR.Click += new System.EventHandler(this.ExitUR_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showConsoleToolStripMenuItem,
            this.closeAllExcelsToolStripMenuItem,
            this.regLibOfficeToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(48, 20);
            this.OptionsMenu.Text = "Tools";
            // 
            // showConsoleToolStripMenuItem
            // 
            this.showConsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showConsoleToolStripMenuItem.Image")));
            this.showConsoleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showConsoleToolStripMenuItem.Name = "showConsoleToolStripMenuItem";
            this.showConsoleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.showConsoleToolStripMenuItem.Text = "Show Console";
            this.showConsoleToolStripMenuItem.Click += new System.EventHandler(this.ShowConsole_Click);
            // 
            // closeAllExcelsToolStripMenuItem
            // 
            this.closeAllExcelsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeAllExcelsToolStripMenuItem.Image")));
            this.closeAllExcelsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.closeAllExcelsToolStripMenuItem.Name = "closeAllExcelsToolStripMenuItem";
            this.closeAllExcelsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeAllExcelsToolStripMenuItem.Text = "Close all Excel";
            this.closeAllExcelsToolStripMenuItem.Click += new System.EventHandler(this.CloseAllExcel_Click);
            // 
            // regLibOfficeToolStripMenuItem
            // 
            this.regLibOfficeToolStripMenuItem.Enabled = false;
            this.regLibOfficeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.regLibOfficeToolStripMenuItem.Name = "regLibOfficeToolStripMenuItem";
            this.regLibOfficeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.regLibOfficeToolStripMenuItem.Text = "RegLibOffice";
            this.regLibOfficeToolStripMenuItem.Click += new System.EventHandler(this.RigesterCOMfix);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // universalReaderToolStripMenu
            // 
            this.universalReaderToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.xFAReaderToolStripMenuItem});
            this.universalReaderToolStripMenu.Name = "universalReaderToolStripMenu";
            this.universalReaderToolStripMenu.Size = new System.Drawing.Size(108, 20);
            this.universalReaderToolStripMenu.Text = "Universal Reader";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.FileWriter);
            // 
            // xFAReaderToolStripMenuItem
            // 
            this.xFAReaderToolStripMenuItem.Enabled = false;
            this.xFAReaderToolStripMenuItem.Name = "xFAReaderToolStripMenuItem";
            this.xFAReaderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.xFAReaderToolStripMenuItem.Text = "XFA reader";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(53, 20);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Click += new System.EventHandler(this.aboutShow);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.OptionsMenu,
            this.universalReaderToolStripMenu,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabMicrogeneration
            // 
            this.tabMicrogeneration.Controls.Add(this.g);
            this.tabMicrogeneration.Controls.Add(this.mgSplitContainer_vertical);
            this.tabMicrogeneration.Location = new System.Drawing.Point(4, 23);
            this.tabMicrogeneration.Name = "tabMicrogeneration";
            this.tabMicrogeneration.Padding = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tabMicrogeneration.Size = new System.Drawing.Size(1203, 590);
            this.tabMicrogeneration.TabIndex = 1;
            this.tabMicrogeneration.Text = "Microgeneration";
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.Control;
            this.g.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.g.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mgBtnNewProject,
            this.mgBtnOpenFile,
            this.mgBtnSaveDats,
            this.toolStripSeparator5,
            this.mgBtnImportFile,
            this.toolStripSeparator4,
            this.toolBtnConvertFile,
            this.toolBtnDictionaryList,
            this.toolBtnDictionaryEditor,
            this.mgBtnOpenFolder,
            this.toolStripButton3,
            this.toolBtnMounth,
            this.toolBtnYear,
            this.toolStripButton4,
            this.mgOpenDataTable,
            this.mgDataСalculation,
            this.mgDataAct});
            this.g.Location = new System.Drawing.Point(3, 3);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(1197, 25);
            this.g.TabIndex = 4;
            this.g.Text = "mgTools";
            // 
            // mgBtnNewProject
            // 
            this.mgBtnNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnNewProject.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnNewProject.Image")));
            this.mgBtnNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnNewProject.Name = "mgBtnNewProject";
            this.mgBtnNewProject.Size = new System.Drawing.Size(23, 22);
            this.mgBtnNewProject.Text = "New Project";
            this.mgBtnNewProject.Click += new System.EventHandler(this.mgBtnNewProject_Click);
            // 
            // mgBtnOpenFile
            // 
            this.mgBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnOpenFile.Image")));
            this.mgBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnOpenFile.Name = "mgBtnOpenFile";
            this.mgBtnOpenFile.Size = new System.Drawing.Size(23, 22);
            this.mgBtnOpenFile.Text = "Open File";
            // 
            // mgBtnSaveDats
            // 
            this.mgBtnSaveDats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnSaveDats.Enabled = false;
            this.mgBtnSaveDats.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnSaveDats.Image")));
            this.mgBtnSaveDats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnSaveDats.Name = "mgBtnSaveDats";
            this.mgBtnSaveDats.Size = new System.Drawing.Size(23, 22);
            this.mgBtnSaveDats.Text = "Save Data";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // mgBtnImportFile
            // 
            this.mgBtnImportFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnImportFile.Enabled = false;
            this.mgBtnImportFile.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnImportFile.Image")));
            this.mgBtnImportFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnImportFile.Name = "mgBtnImportFile";
            this.mgBtnImportFile.Size = new System.Drawing.Size(32, 22);
            this.mgBtnImportFile.Text = "ImportFile";
            this.mgBtnImportFile.ButtonClick += new System.EventHandler(this.mgBtnImportFile_ButtonClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnConvertFile
            // 
            this.toolBtnConvertFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnConvertFile.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnConvertFile.Image")));
            this.toolBtnConvertFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnConvertFile.Name = "toolBtnConvertFile";
            this.toolBtnConvertFile.Size = new System.Drawing.Size(23, 22);
            this.toolBtnConvertFile.Text = "ConvertFile";
            this.toolBtnConvertFile.Click += new System.EventHandler(this.openPDFviewer_Click);
            // 
            // toolBtnDictionaryList
            // 
            this.toolBtnDictionaryList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDictionaryList.Enabled = false;
            this.toolBtnDictionaryList.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDictionaryList.Image")));
            this.toolBtnDictionaryList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBtnDictionaryList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDictionaryList.Name = "toolBtnDictionaryList";
            this.toolBtnDictionaryList.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDictionaryList.Text = "DictionaryList";
            this.toolBtnDictionaryList.Click += new System.EventHandler(this.OpenDictionaryList_Click);
            // 
            // toolBtnDictionaryEditor
            // 
            this.toolBtnDictionaryEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDictionaryEditor.Enabled = false;
            this.toolBtnDictionaryEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnDictionaryEditor.Image")));
            this.toolBtnDictionaryEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDictionaryEditor.Name = "toolBtnDictionaryEditor";
            this.toolBtnDictionaryEditor.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDictionaryEditor.Text = "DictionaryEditor";
            this.toolBtnDictionaryEditor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolBtnDictionaryEditor.Click += new System.EventHandler(this.toolBtnDictionaryEditor_Click);
            // 
            // mgBtnOpenFolder
            // 
            this.mgBtnOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnOpenFolder.Enabled = false;
            this.mgBtnOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnOpenFolder.Image")));
            this.mgBtnOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnOpenFolder.Name = "mgBtnOpenFolder";
            this.mgBtnOpenFolder.Size = new System.Drawing.Size(23, 22);
            this.mgBtnOpenFolder.Text = "Show in Windows";
            this.mgBtnOpenFolder.Click += new System.EventHandler(this.mgBtnOpenFolder_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnMounth
            // 
            this.toolBtnMounth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.toolBtnMounth.Name = "toolBtnMounth";
            this.toolBtnMounth.Size = new System.Drawing.Size(75, 25);
            this.toolBtnMounth.Text = "Mounth";
            // 
            // toolBtnYear
            // 
            this.toolBtnYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024"});
            this.toolBtnYear.Name = "toolBtnYear";
            this.toolBtnYear.Size = new System.Drawing.Size(75, 25);
            this.toolBtnYear.Text = "Year";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // mgOpenDataTable
            // 
            this.mgOpenDataTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgOpenDataTable.Image = ((System.Drawing.Image)(resources.GetObject("mgOpenDataTable.Image")));
            this.mgOpenDataTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgOpenDataTable.Name = "mgOpenDataTable";
            this.mgOpenDataTable.Size = new System.Drawing.Size(23, 22);
            this.mgOpenDataTable.Text = "OpenDataTable";
            this.mgOpenDataTable.Click += new System.EventHandler(this.mgOpenDataTable_Click);
            // 
            // mgDataСalculation
            // 
            this.mgDataСalculation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgDataСalculation.Image = ((System.Drawing.Image)(resources.GetObject("mgDataСalculation.Image")));
            this.mgDataСalculation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgDataСalculation.Name = "mgDataСalculation";
            this.mgDataСalculation.Size = new System.Drawing.Size(23, 22);
            this.mgDataСalculation.Text = "OpenСalculation";
            this.mgDataСalculation.Click += new System.EventHandler(this.mgDataСalculation_Click);
            // 
            // mgDataAct
            // 
            this.mgDataAct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgDataAct.Image = ((System.Drawing.Image)(resources.GetObject("mgDataAct.Image")));
            this.mgDataAct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgDataAct.Name = "mgDataAct";
            this.mgDataAct.Size = new System.Drawing.Size(23, 22);
            this.mgDataAct.Text = "OpenAct";
            this.mgDataAct.Click += new System.EventHandler(this.mgDataAct_Click);
            // 
            // mgSplitContainer_vertical
            // 
            this.mgSplitContainer_vertical.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgSplitContainer_vertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mgSplitContainer_vertical.Location = new System.Drawing.Point(3, 31);
            this.mgSplitContainer_vertical.Name = "mgSplitContainer_vertical";
            this.mgSplitContainer_vertical.Panel1Collapsed = true;
            this.mgSplitContainer_vertical.Panel1MinSize = 250;
            // 
            // mgSplitContainer_vertical.Panel2
            // 
            this.mgSplitContainer_vertical.Panel2.Controls.Add(this.mgSplitContainer_horizontal);
            this.mgSplitContainer_vertical.Panel2MinSize = 300;
            this.mgSplitContainer_vertical.Size = new System.Drawing.Size(1197, 564);
            this.mgSplitContainer_vertical.SplitterDistance = 250;
            this.mgSplitContainer_vertical.TabIndex = 0;
            // 
            // mgSplitContainer_horizontal
            // 
            this.mgSplitContainer_horizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgSplitContainer_horizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mgSplitContainer_horizontal.IsSplitterFixed = true;
            this.mgSplitContainer_horizontal.Location = new System.Drawing.Point(0, 0);
            this.mgSplitContainer_horizontal.Name = "mgSplitContainer_horizontal";
            this.mgSplitContainer_horizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mgSplitContainer_horizontal.Panel1
            // 
            this.mgSplitContainer_horizontal.Panel1.Controls.Add(this.upperTableLayoutMainData);
            this.mgSplitContainer_horizontal.Panel1MinSize = 60;
            // 
            // mgSplitContainer_horizontal.Panel2
            // 
            this.mgSplitContainer_horizontal.Panel2.Controls.Add(this.tabControlCurrentProject);
            this.mgSplitContainer_horizontal.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.mgSplitContainer_horizontal.Panel2MinSize = 100;
            this.mgSplitContainer_horizontal.Size = new System.Drawing.Size(1197, 564);
            this.mgSplitContainer_horizontal.SplitterDistance = 85;
            this.mgSplitContainer_horizontal.TabIndex = 3;
            // 
            // upperTableLayoutMainData
            // 
            this.upperTableLayoutMainData.ColumnCount = 2;
            this.upperTableLayoutMainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.95155F));
            this.upperTableLayoutMainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.04845F));
            this.upperTableLayoutMainData.Controls.Add(this.lblMainName, 0, 0);
            this.upperTableLayoutMainData.Controls.Add(this.textBoxNameGP, 1, 3);
            this.upperTableLayoutMainData.Controls.Add(this.lblSubject, 0, 1);
            this.upperTableLayoutMainData.Controls.Add(this.textBoxGTPcode, 1, 2);
            this.upperTableLayoutMainData.Controls.Add(this.lblNameGP, 0, 3);
            this.upperTableLayoutMainData.Controls.Add(this.textBoxSubject, 1, 1);
            this.upperTableLayoutMainData.Controls.Add(this.lblGTPcode, 0, 2);
            this.upperTableLayoutMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperTableLayoutMainData.Location = new System.Drawing.Point(0, 0);
            this.upperTableLayoutMainData.Margin = new System.Windows.Forms.Padding(1);
            this.upperTableLayoutMainData.Name = "upperTableLayoutMainData";
            this.upperTableLayoutMainData.RowCount = 4;
            this.upperTableLayoutMainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.67857F));
            this.upperTableLayoutMainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.10714F));
            this.upperTableLayoutMainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.10714F));
            this.upperTableLayoutMainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.10714F));
            this.upperTableLayoutMainData.Size = new System.Drawing.Size(1197, 85);
            this.upperTableLayoutMainData.TabIndex = 0;
            // 
            // lblMainName
            // 
            this.lblMainName.AutoSize = true;
            this.upperTableLayoutMainData.SetColumnSpan(this.lblMainName, 2);
            this.lblMainName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMainName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainName.Location = new System.Drawing.Point(1, 1);
            this.lblMainName.Margin = new System.Windows.Forms.Padding(1);
            this.lblMainName.Name = "lblMainName";
            this.lblMainName.Size = new System.Drawing.Size(359, 21);
            this.lblMainName.TabIndex = 1;
            this.lblMainName.Text = "Transaction MKG_REALESE_CLOSE: april 2023";
            this.lblMainName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxNameGP
            // 
            this.textBoxNameGP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxNameGP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameGP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameGP.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxNameGP.Location = new System.Drawing.Point(167, 63);
            this.textBoxNameGP.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxNameGP.Name = "textBoxNameGP";
            this.textBoxNameGP.Size = new System.Drawing.Size(1030, 21);
            this.textBoxNameGP.TabIndex = 6;
            this.textBoxNameGP.WordWrap = false;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSubject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubject.Location = new System.Drawing.Point(1, 24);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(1);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(78, 18);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Субъект РФ:";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxGTPcode
            // 
            this.textBoxGTPcode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxGTPcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGTPcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGTPcode.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxGTPcode.Location = new System.Drawing.Point(167, 43);
            this.textBoxGTPcode.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxGTPcode.Name = "textBoxGTPcode";
            this.textBoxGTPcode.Size = new System.Drawing.Size(1030, 21);
            this.textBoxGTPcode.TabIndex = 5;
            this.textBoxGTPcode.WordWrap = false;
            // 
            // lblNameGP
            // 
            this.lblNameGP.AutoSize = true;
            this.lblNameGP.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNameGP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameGP.Location = new System.Drawing.Point(1, 64);
            this.lblNameGP.Margin = new System.Windows.Forms.Padding(1);
            this.lblNameGP.Name = "lblNameGP";
            this.lblNameGP.Size = new System.Drawing.Size(155, 20);
            this.lblNameGP.TabIndex = 1;
            this.lblNameGP.Text = "Наименование участника:";
            this.lblNameGP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSubject.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubject.Location = new System.Drawing.Point(167, 23);
            this.textBoxSubject.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(1030, 21);
            this.textBoxSubject.TabIndex = 4;
            this.textBoxSubject.WordWrap = false;
            // 
            // lblGTPcode
            // 
            this.lblGTPcode.AutoSize = true;
            this.lblGTPcode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGTPcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGTPcode.Location = new System.Drawing.Point(1, 44);
            this.lblGTPcode.Margin = new System.Windows.Forms.Padding(1);
            this.lblGTPcode.Name = "lblGTPcode";
            this.lblGTPcode.Size = new System.Drawing.Size(58, 18);
            this.lblGTPcode.TabIndex = 2;
            this.lblGTPcode.Text = "Код ГТП:";
            this.lblGTPcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControlCurrentProject
            // 
            this.tabControlCurrentProject.Controls.Add(this.tabBasic);
            this.tabControlCurrentProject.Controls.Add(this.tabDetail);
            this.tabControlCurrentProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCurrentProject.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlCurrentProject.Location = new System.Drawing.Point(0, 0);
            this.tabControlCurrentProject.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlCurrentProject.Name = "tabControlCurrentProject";
            this.tabControlCurrentProject.Padding = new System.Drawing.Point(10, 3);
            this.tabControlCurrentProject.SelectedIndex = 0;
            this.tabControlCurrentProject.Size = new System.Drawing.Size(1197, 475);
            this.tabControlCurrentProject.TabIndex = 4;
            // 
            // tabBasic
            // 
            this.tabBasic.BackColor = System.Drawing.SystemColors.Control;
            this.tabBasic.Location = new System.Drawing.Point(4, 23);
            this.tabBasic.Margin = new System.Windows.Forms.Padding(0);
            this.tabBasic.Name = "tabBasic";
            this.tabBasic.Size = new System.Drawing.Size(1189, 448);
            this.tabBasic.TabIndex = 0;
            this.tabBasic.Text = "Basic data";
            // 
            // tabDetail
            // 
            this.tabDetail.BackColor = System.Drawing.SystemColors.Control;
            this.tabDetail.Controls.Add(this.mgSplitContainer_insideHorizontal);
            this.tabDetail.Location = new System.Drawing.Point(4, 23);
            this.tabDetail.Margin = new System.Windows.Forms.Padding(0);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Size = new System.Drawing.Size(1189, 447);
            this.tabDetail.TabIndex = 1;
            this.tabDetail.Text = "Detail";
            // 
            // mgSplitContainer_insideHorizontal
            // 
            this.mgSplitContainer_insideHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgSplitContainer_insideHorizontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mgSplitContainer_insideHorizontal.Location = new System.Drawing.Point(0, 0);
            this.mgSplitContainer_insideHorizontal.Name = "mgSplitContainer_insideHorizontal";
            this.mgSplitContainer_insideHorizontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mgSplitContainer_insideHorizontal.Panel1
            // 
            this.mgSplitContainer_insideHorizontal.Panel1.Controls.Add(this.mgSplitContainer_inside_vertical);
            // 
            // mgSplitContainer_insideHorizontal.Panel2
            // 
            this.mgSplitContainer_insideHorizontal.Panel2.Controls.Add(this.inputTableLoyaut);
            this.mgSplitContainer_insideHorizontal.Size = new System.Drawing.Size(1189, 447);
            this.mgSplitContainer_insideHorizontal.SplitterDistance = 418;
            this.mgSplitContainer_insideHorizontal.TabIndex = 3;
            // 
            // mgSplitContainer_inside_vertical
            // 
            this.mgSplitContainer_inside_vertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgSplitContainer_inside_vertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.mgSplitContainer_inside_vertical.Location = new System.Drawing.Point(0, 0);
            this.mgSplitContainer_inside_vertical.Name = "mgSplitContainer_inside_vertical";
            // 
            // mgSplitContainer_inside_vertical.Panel1
            // 
            this.mgSplitContainer_inside_vertical.Panel1.Controls.Add(this.mgDataViewer);
            this.mgSplitContainer_inside_vertical.Panel1MinSize = 500;
            // 
            // mgSplitContainer_inside_vertical.Panel2
            // 
            this.mgSplitContainer_inside_vertical.Panel2.Controls.Add(this.mgSplitContainer_insideRight);
            this.mgSplitContainer_inside_vertical.Panel2MinSize = 125;
            this.mgSplitContainer_inside_vertical.Size = new System.Drawing.Size(1189, 418);
            this.mgSplitContainer_inside_vertical.SplitterDistance = 971;
            this.mgSplitContainer_inside_vertical.TabIndex = 0;
            // 
            // mgDataViewer
            // 
            this.mgDataViewer.AllowDrop = true;
            this.mgDataViewer.AllowUserToAddRows = false;
            this.mgDataViewer.AllowUserToDeleteRows = false;
            this.mgDataViewer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.mgDataViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mgDataViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgDataViewer.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.mgDataViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mgDataViewer.ColumnHeadersHeight = 25;
            this.mgDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mgDataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataTable,
            this.Agreement,
            this.FullName,
            this.DateAgreement,
            this.type,
            this.TariffZone,
            this.NumCC,
            this.REC,
            this.GEN,
            this.SELL,
            this.BUY,
            this.Price,
            this.Cost,
            this.dataCalculation,
            this.dataAct,
            this.OpenFolder});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataViewer.DefaultCellStyle = dataGridViewCellStyle6;
            this.mgDataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgDataViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mgDataViewer.EnableHeadersVisualStyles = false;
            this.mgDataViewer.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mgDataViewer.Location = new System.Drawing.Point(0, 0);
            this.mgDataViewer.MultiSelect = false;
            this.mgDataViewer.Name = "mgDataViewer";
            this.mgDataViewer.ReadOnly = true;
            this.mgDataViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgDataViewer.RowHeadersVisible = false;
            this.mgDataViewer.RowHeadersWidth = 20;
            this.mgDataViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgDataViewer.RowTemplate.Height = 20;
            this.mgDataViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mgDataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgDataViewer.Size = new System.Drawing.Size(971, 418);
            this.mgDataViewer.TabIndex = 2;
            this.mgDataViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgDataViewer_CellClick);
            this.mgDataViewer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.mgDataViewer_CellPainting);
            this.mgDataViewer.SelectionChanged += new System.EventHandler(this.mgDataViewer_SelectionChanged);
            this.mgDataViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.mgDataViewer_DragDrop);
            this.mgDataViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.mgDataViewer_DragEnter);
            this.mgDataViewer.DragLeave += new System.EventHandler(this.mgDataViewer_DragLeave);
            this.mgDataViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mgDataViewer_MouseDown);
            this.mgDataViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mgDataViewer_MouseMove);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 25;
            // 
            // dataTable
            // 
            this.dataTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataTable.HeaderText = "R";
            this.dataTable.MinimumWidth = 25;
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataTable.Width = 25;
            // 
            // Agreement
            // 
            this.Agreement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Agreement.HeaderText = "Agreement";
            this.Agreement.Name = "Agreement";
            this.Agreement.ReadOnly = true;
            this.Agreement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Agreement.Width = 74;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 43;
            // 
            // DateAgreement
            // 
            this.DateAgreement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.DateAgreement.DefaultCellStyle = dataGridViewCellStyle4;
            this.DateAgreement.HeaderText = "Date";
            this.DateAgreement.Name = "DateAgreement";
            this.DateAgreement.ReadOnly = true;
            this.DateAgreement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DateAgreement.Width = 38;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.type.DefaultCellStyle = dataGridViewCellStyle5;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.type.Width = 40;
            // 
            // TariffZone
            // 
            this.TariffZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TariffZone.HeaderText = "Tariff";
            this.TariffZone.Name = "TariffZone";
            this.TariffZone.ReadOnly = true;
            this.TariffZone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TariffZone.Width = 40;
            // 
            // NumCC
            // 
            this.NumCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NumCC.HeaderText = "№Counter";
            this.NumCC.Name = "NumCC";
            this.NumCC.ReadOnly = true;
            this.NumCC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NumCC.Width = 70;
            // 
            // REC
            // 
            this.REC.HeaderText = "REC";
            this.REC.MinimumWidth = 30;
            this.REC.Name = "REC";
            this.REC.ReadOnly = true;
            this.REC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GEN
            // 
            this.GEN.HeaderText = "GEN";
            this.GEN.MinimumWidth = 30;
            this.GEN.Name = "GEN";
            this.GEN.ReadOnly = true;
            this.GEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SELL
            // 
            this.SELL.HeaderText = "SELL";
            this.SELL.MinimumWidth = 30;
            this.SELL.Name = "SELL";
            this.SELL.ReadOnly = true;
            this.SELL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BUY
            // 
            this.BUY.HeaderText = "BUY";
            this.BUY.MinimumWidth = 30;
            this.BUY.Name = "BUY";
            this.BUY.ReadOnly = true;
            this.BUY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 30;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 30;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataCalculation
            // 
            this.dataCalculation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataCalculation.HeaderText = "S";
            this.dataCalculation.MinimumWidth = 25;
            this.dataCalculation.Name = "dataCalculation";
            this.dataCalculation.ReadOnly = true;
            this.dataCalculation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCalculation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataCalculation.Width = 25;
            // 
            // dataAct
            // 
            this.dataAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataAct.HeaderText = "D";
            this.dataAct.MinimumWidth = 25;
            this.dataAct.Name = "dataAct";
            this.dataAct.ReadOnly = true;
            this.dataAct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAct.Width = 25;
            // 
            // OpenFolder
            // 
            this.OpenFolder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OpenFolder.HeaderText = "F";
            this.OpenFolder.MinimumWidth = 25;
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.ReadOnly = true;
            this.OpenFolder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OpenFolder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OpenFolder.Width = 25;
            // 
            // mgSplitContainer_insideRight
            // 
            this.mgSplitContainer_insideRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgSplitContainer_insideRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mgSplitContainer_insideRight.Location = new System.Drawing.Point(0, 0);
            this.mgSplitContainer_insideRight.Name = "mgSplitContainer_insideRight";
            this.mgSplitContainer_insideRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mgSplitContainer_insideRight.Panel1
            // 
            this.mgSplitContainer_insideRight.Panel1.Controls.Add(this.groupBoxRes);
            this.mgSplitContainer_insideRight.Panel1MinSize = 80;
            // 
            // mgSplitContainer_insideRight.Panel2
            // 
            this.mgSplitContainer_insideRight.Panel2.Controls.Add(this.groupBoxData);
            this.mgSplitContainer_insideRight.Panel2MinSize = 100;
            this.mgSplitContainer_insideRight.Size = new System.Drawing.Size(214, 418);
            this.mgSplitContainer_insideRight.SplitterDistance = 80;
            this.mgSplitContainer_insideRight.TabIndex = 2;
            // 
            // groupBoxRes
            // 
            this.groupBoxRes.Controls.Add(this.ResourcesTreeView);
            this.groupBoxRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes.Name = "groupBoxRes";
            this.groupBoxRes.Size = new System.Drawing.Size(214, 80);
            this.groupBoxRes.TabIndex = 0;
            this.groupBoxRes.TabStop = false;
            this.groupBoxRes.Text = "Resources manager";
            // 
            // ResourcesTreeView
            // 
            this.ResourcesTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.ResourcesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResourcesTreeView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResourcesTreeView.ImageKey = "FolderOpened.png";
            this.ResourcesTreeView.ImageList = this.imgList;
            this.ResourcesTreeView.Location = new System.Drawing.Point(3, 18);
            this.ResourcesTreeView.Name = "ResourcesTreeView";
            this.ResourcesTreeView.SelectedImageIndex = 0;
            this.ResourcesTreeView.Size = new System.Drawing.Size(208, 59);
            this.ResourcesTreeView.TabIndex = 2;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "FolderOpened.png");
            this.imgList.Images.SetKeyName(1, "ShowDataPreview.png");
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.mgFlowPanelResult);
            this.groupBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(214, 334);
            this.groupBoxData.TabIndex = 2;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Extracted data";
            // 
            // mgFlowPanelResult
            // 
            this.mgFlowPanelResult.AllowDrop = true;
            this.mgFlowPanelResult.AutoScroll = true;
            this.mgFlowPanelResult.AutoSize = true;
            this.mgFlowPanelResult.BackColor = System.Drawing.SystemColors.Control;
            this.mgFlowPanelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mgFlowPanelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgFlowPanelResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mgFlowPanelResult.Location = new System.Drawing.Point(3, 18);
            this.mgFlowPanelResult.Name = "mgFlowPanelResult";
            this.mgFlowPanelResult.Size = new System.Drawing.Size(208, 313);
            this.mgFlowPanelResult.TabIndex = 1;
            this.mgFlowPanelResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.mgFlowPanelResult_DragDrop);
            this.mgFlowPanelResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.mgFlowPanelResult_DragEnter);
            // 
            // inputTableLoyaut
            // 
            this.inputTableLoyaut.ColumnCount = 1;
            this.inputTableLoyaut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLoyaut.Controls.Add(this.datsTreeView, 0, 1);
            this.inputTableLoyaut.Controls.Add(this.mgToolStripInputData, 0, 0);
            this.inputTableLoyaut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLoyaut.Location = new System.Drawing.Point(0, 0);
            this.inputTableLoyaut.Name = "inputTableLoyaut";
            this.inputTableLoyaut.RowCount = 2;
            this.inputTableLoyaut.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLoyaut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLoyaut.Size = new System.Drawing.Size(1189, 25);
            this.inputTableLoyaut.TabIndex = 0;
            // 
            // datsTreeView
            // 
            this.datsTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.datsTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datsTreeView.LabelEdit = true;
            this.datsTreeView.Location = new System.Drawing.Point(3, 28);
            this.datsTreeView.Name = "datsTreeView";
            treeNode1.Name = "treeViewLine1e1val";
            treeNode1.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "null";
            treeNode2.Name = "treeViewLine1";
            treeNode2.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Коэффициент оплаты мощности потребителями (покупателями), осуществляющими расчеты" +
    " по 1ЦК, 1/час";
            treeNode3.Name = "treeViewLine2e1val";
            treeNode3.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "null";
            treeNode4.Name = "treeViewLine2";
            treeNode4.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Средневзвешенная нерегулируемая цена на мощность на оптовом рынке, руб/МВт";
            treeNode5.Name = "treeViewLine3e1val";
            treeNode5.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "null";
            treeNode6.Name = "treeViewLine3";
            treeNode6.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Средневзвешенная нерегулируемая цена на электрическую энергию на оптовом рынке, о" +
    "пределяемая по результатам конкурентных отборов на сутки вперед, руб/МВтч";
            treeNode7.Name = "treeViewLine4e1val";
            treeNode7.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "null";
            treeNode8.Name = "treeViewLine4e1";
            treeNode8.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "ночная зона суток";
            treeNode9.Name = "treeViewLine4e2val";
            treeNode9.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "null";
            treeNode10.Name = "treeViewLine4e2";
            treeNode10.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "полупиковая зона суток";
            treeNode11.Name = "treeViewLine4e3val";
            treeNode11.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode11.Text = "null";
            treeNode12.Name = "treeViewLine4e3";
            treeNode12.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode12.Text = "пиковая зона суток";
            treeNode13.Name = "treeViewLine4";
            treeNode13.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode13.Text = resources.GetString("treeNode13.Text");
            treeNode14.Name = "treeViewLine5e1val";
            treeNode14.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode14.Text = "null";
            treeNode15.Name = "treeViewLine5e1";
            treeNode15.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode15.Text = "ночная зона суток";
            treeNode16.Name = "treeViewLine5e2val";
            treeNode16.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode16.Text = "null";
            treeNode17.Name = "treeViewLine5e2";
            treeNode17.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode17.Text = "дневная зона суток";
            treeNode18.Name = "treeViewLine5";
            treeNode18.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode18.Text = resources.GetString("treeNode18.Text");
            treeNode19.Name = "treeViewLine6e1val";
            treeNode19.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode19.Text = "null";
            treeNode20.Name = "treeViewLine6e1";
            treeNode20.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode20.Text = "ночная зона суток";
            treeNode21.Name = "treeViewLine6e2val";
            treeNode21.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode21.Text = "null";
            treeNode22.Name = "treeViewLine6e2";
            treeNode22.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode22.Text = "полупиковая зона суток";
            treeNode23.Name = "treeViewLine6e3val";
            treeNode23.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode23.Text = "null";
            treeNode24.Name = "treeViewLine6e3";
            treeNode24.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode24.Text = "пиковая зона суток";
            treeNode25.Name = "treeViewLine6";
            treeNode25.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode25.Text = "Коэффициент оплаты мощности для соответствующих зон суток (три зоны суток)";
            treeNode26.Name = "treeViewLine7e1val";
            treeNode26.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode26.Text = "null";
            treeNode27.Name = "treeViewLine7e1";
            treeNode27.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode27.Text = "ночная зона суток";
            treeNode28.Name = "treeViewLine7e2val";
            treeNode28.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode28.Text = "null";
            treeNode29.Name = "treeViewLine7e2";
            treeNode29.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode29.Text = "дневная зона суток";
            treeNode30.Name = "treeViewLine7";
            treeNode30.NodeFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode30.Text = "Коэффициент оплаты мощности для соответствующих зон суток (две зоны суток)";
            this.datsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode13,
            treeNode18,
            treeNode25,
            treeNode30});
            this.datsTreeView.Size = new System.Drawing.Size(1183, 1);
            this.datsTreeView.TabIndex = 2;
            // 
            // mgToolStripInputData
            // 
            this.mgToolStripInputData.BackColor = System.Drawing.SystemColors.Control;
            this.mgToolStripInputData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mgToolStripInputData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mgBtnEntryDatFiles,
            this.mgFileSPUNCbtn,
            this.mgFileSVNCbtn,
            this.mgFileKFbtn,
            this.imgStatusOk,
            this.imgStatusDwnld,
            this.imgStatusFailed});
            this.mgToolStripInputData.Location = new System.Drawing.Point(0, 0);
            this.mgToolStripInputData.Name = "mgToolStripInputData";
            this.mgToolStripInputData.Size = new System.Drawing.Size(1189, 25);
            this.mgToolStripInputData.TabIndex = 3;
            // 
            // mgBtnEntryDatFiles
            // 
            this.mgBtnEntryDatFiles.BackColor = System.Drawing.SystemColors.Control;
            this.mgBtnEntryDatFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mgBtnEntryDatFiles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mgFileSPUNC,
            this.mgFileSVNC,
            this.mgFileKF});
            this.mgBtnEntryDatFiles.Enabled = false;
            this.mgBtnEntryDatFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mgBtnEntryDatFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mgBtnEntryDatFiles.Image = ((System.Drawing.Image)(resources.GetObject("mgBtnEntryDatFiles.Image")));
            this.mgBtnEntryDatFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgBtnEntryDatFiles.Name = "mgBtnEntryDatFiles";
            this.mgBtnEntryDatFiles.Size = new System.Drawing.Size(32, 22);
            this.mgBtnEntryDatFiles.Text = "Данные";
            this.mgBtnEntryDatFiles.ButtonClick += new System.EventHandler(this.mgBtnEntryDatFiles_ButtonClick);
            // 
            // mgFileSPUNC
            // 
            this.mgFileSPUNC.Name = "mgFileSPUNC";
            this.mgFileSPUNC.Size = new System.Drawing.Size(160, 22);
            this.mgFileSPUNC.Text = "СПУНЦ";
            // 
            // mgFileSVNC
            // 
            this.mgFileSVNC.Name = "mgFileSVNC";
            this.mgFileSVNC.Size = new System.Drawing.Size(160, 22);
            this.mgFileSVNC.Text = "СВНЦ (АТС)";
            // 
            // mgFileKF
            // 
            this.mgFileKF.Name = "mgFileKF";
            this.mgFileKF.Size = new System.Drawing.Size(160, 22);
            this.mgFileKF.Text = "Коэффициенты";
            // 
            // mgFileSPUNCbtn
            // 
            this.mgFileSPUNCbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mgFileSPUNCbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mgFileSPUNCbtn.Image = ((System.Drawing.Image)(resources.GetObject("mgFileSPUNCbtn.Image")));
            this.mgFileSPUNCbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgFileSPUNCbtn.Name = "mgFileSPUNCbtn";
            this.mgFileSPUNCbtn.Size = new System.Drawing.Size(55, 22);
            this.mgFileSPUNCbtn.Text = "СПУНЦ";
            this.mgFileSPUNCbtn.ToolTipText = "СПУНЦ";
            this.mgFileSPUNCbtn.Visible = false;
            // 
            // mgFileSVNCbtn
            // 
            this.mgFileSVNCbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mgFileSVNCbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mgFileSVNCbtn.Image = ((System.Drawing.Image)(resources.GetObject("mgFileSVNCbtn.Image")));
            this.mgFileSVNCbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mgFileSVNCbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgFileSVNCbtn.Name = "mgFileSVNCbtn";
            this.mgFileSVNCbtn.Size = new System.Drawing.Size(46, 22);
            this.mgFileSVNCbtn.Text = "СВНЦ";
            this.mgFileSVNCbtn.ToolTipText = "СВНЦ";
            this.mgFileSVNCbtn.Visible = false;
            this.mgFileSVNCbtn.Click += new System.EventHandler(this.mgFileSVNC_Click);
            // 
            // mgFileKFbtn
            // 
            this.mgFileKFbtn.BackColor = System.Drawing.SystemColors.Control;
            this.mgFileKFbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mgFileKFbtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mgFileKFbtn.Image = ((System.Drawing.Image)(resources.GetObject("mgFileKFbtn.Image")));
            this.mgFileKFbtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mgFileKFbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mgFileKFbtn.Name = "mgFileKFbtn";
            this.mgFileKFbtn.Size = new System.Drawing.Size(48, 22);
            this.mgFileKFbtn.Text = "Коэф.";
            this.mgFileKFbtn.ToolTipText = "Коэффициенты";
            this.mgFileKFbtn.Visible = false;
            this.mgFileKFbtn.Click += new System.EventHandler(this.mgFileKF_Click);
            // 
            // imgStatusOk
            // 
            this.imgStatusOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imgStatusOk.Image = ((System.Drawing.Image)(resources.GetObject("imgStatusOk.Image")));
            this.imgStatusOk.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imgStatusOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imgStatusOk.Name = "imgStatusOk";
            this.imgStatusOk.Size = new System.Drawing.Size(23, 22);
            this.imgStatusOk.Visible = false;
            // 
            // imgStatusDwnld
            // 
            this.imgStatusDwnld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imgStatusDwnld.Image = ((System.Drawing.Image)(resources.GetObject("imgStatusDwnld.Image")));
            this.imgStatusDwnld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imgStatusDwnld.Name = "imgStatusDwnld";
            this.imgStatusDwnld.Size = new System.Drawing.Size(23, 22);
            this.imgStatusDwnld.Visible = false;
            // 
            // imgStatusFailed
            // 
            this.imgStatusFailed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imgStatusFailed.Image = ((System.Drawing.Image)(resources.GetObject("imgStatusFailed.Image")));
            this.imgStatusFailed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imgStatusFailed.Name = "imgStatusFailed";
            this.imgStatusFailed.Size = new System.Drawing.Size(23, 22);
            this.imgStatusFailed.Visible = false;
            // 
            // appInfo
            // 
            this.appInfo.AutoSize = true;
            this.appInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.appInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.appInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.appInfo.Location = new System.Drawing.Point(1156, 0);
            this.appInfo.Name = "appInfo";
            this.appInfo.Size = new System.Drawing.Size(52, 25);
            this.appInfo.TabIndex = 77;
            this.appInfo.Text = "appName";
            this.appInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabExcel
            // 
            this.tabExcel.BackColor = System.Drawing.Color.Transparent;
            this.tabExcel.Controls.Add(this.urToolStrip);
            this.tabExcel.Controls.Add(this.splitContainer_bigMain);
            this.tabExcel.Location = new System.Drawing.Point(4, 23);
            this.tabExcel.Name = "tabExcel";
            this.tabExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcel.Size = new System.Drawing.Size(1203, 590);
            this.tabExcel.TabIndex = 0;
            this.tabExcel.Text = "ExcelReader";
            // 
            // urToolStrip
            // 
            this.urToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urBtnImportFile,
            this.toolStripSeparator2,
            this.urBtnSaveXML,
            this.urBtnConvert2Tree});
            this.urToolStrip.Location = new System.Drawing.Point(3, 3);
            this.urToolStrip.Name = "urToolStrip";
            this.urToolStrip.Size = new System.Drawing.Size(1197, 25);
            this.urToolStrip.TabIndex = 76;
            this.urToolStrip.Text = "mgTools";
            // 
            // urBtnImportFile
            // 
            this.urBtnImportFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urBtnImportFile.Image = ((System.Drawing.Image)(resources.GetObject("urBtnImportFile.Image")));
            this.urBtnImportFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urBtnImportFile.Name = "urBtnImportFile";
            this.urBtnImportFile.Size = new System.Drawing.Size(32, 22);
            this.urBtnImportFile.Text = "ImportFile";
            this.urBtnImportFile.ButtonClick += new System.EventHandler(this.urBtnImportFile_ButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // urBtnSaveXML
            // 
            this.urBtnSaveXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urBtnSaveXML.Enabled = false;
            this.urBtnSaveXML.Image = ((System.Drawing.Image)(resources.GetObject("urBtnSaveXML.Image")));
            this.urBtnSaveXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urBtnSaveXML.Name = "urBtnSaveXML";
            this.urBtnSaveXML.Size = new System.Drawing.Size(23, 22);
            this.urBtnSaveXML.Text = "Export to XML";
            this.urBtnSaveXML.Click += new System.EventHandler(this.urBtnSaveXML_Click);
            // 
            // urBtnConvert2Tree
            // 
            this.urBtnConvert2Tree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urBtnConvert2Tree.Enabled = false;
            this.urBtnConvert2Tree.Image = ((System.Drawing.Image)(resources.GetObject("urBtnConvert2Tree.Image")));
            this.urBtnConvert2Tree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.urBtnConvert2Tree.Name = "urBtnConvert2Tree";
            this.urBtnConvert2Tree.Size = new System.Drawing.Size(23, 22);
            this.urBtnConvert2Tree.Text = "Tree View";
            this.urBtnConvert2Tree.Click += new System.EventHandler(this.urBtnConvert2Tree_Click);
            // 
            // splitContainer_bigMain
            // 
            this.splitContainer_bigMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_bigMain.Location = new System.Drawing.Point(3, 34);
            this.splitContainer_bigMain.Name = "splitContainer_bigMain";
            // 
            // splitContainer_bigMain.Panel1
            // 
            this.splitContainer_bigMain.Panel1.Controls.Add(this.splitContainer_dataGrids);
            this.splitContainer_bigMain.Panel1MinSize = 90;
            // 
            // splitContainer_bigMain.Panel2
            // 
            this.splitContainer_bigMain.Panel2.Controls.Add(this.splitContainer_rightProps);
            this.splitContainer_bigMain.Panel2MinSize = 300;
            this.splitContainer_bigMain.Size = new System.Drawing.Size(1197, 524);
            this.splitContainer_bigMain.SplitterDistance = 893;
            this.splitContainer_bigMain.TabIndex = 75;
            // 
            // splitContainer_dataGrids
            // 
            this.splitContainer_dataGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_dataGrids.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_dataGrids.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_dataGrids.Name = "splitContainer_dataGrids";
            this.splitContainer_dataGrids.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_dataGrids.Panel1
            // 
            this.splitContainer_dataGrids.Panel1.Controls.Add(this.CellViewer);
            // 
            // splitContainer_dataGrids.Panel2
            // 
            this.splitContainer_dataGrids.Panel2.Controls.Add(this.dataViewer);
            this.splitContainer_dataGrids.Size = new System.Drawing.Size(893, 524);
            this.splitContainer_dataGrids.SplitterDistance = 25;
            this.splitContainer_dataGrids.TabIndex = 2;
            // 
            // CellViewer
            // 
            this.CellViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellViewer.Location = new System.Drawing.Point(0, 0);
            this.CellViewer.Multiline = true;
            this.CellViewer.Name = "CellViewer";
            this.CellViewer.ReadOnly = true;
            this.CellViewer.Size = new System.Drawing.Size(893, 25);
            this.CellViewer.TabIndex = 0;
            // 
            // dataViewer
            // 
            this.dataViewer.AllowDrop = true;
            this.dataViewer.AllowUserToAddRows = false;
            this.dataViewer.AllowUserToDeleteRows = false;
            this.dataViewer.AllowUserToResizeRows = false;
            this.dataViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewer.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataViewer.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataViewer.Location = new System.Drawing.Point(0, 0);
            this.dataViewer.MultiSelect = false;
            this.dataViewer.Name = "dataViewer";
            this.dataViewer.ReadOnly = true;
            this.dataViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataViewer.RowHeadersWidth = 20;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataViewer.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataViewer.RowTemplate.Height = 25;
            this.dataViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataViewer.Size = new System.Drawing.Size(893, 495);
            this.dataViewer.TabIndex = 1;
            this.dataViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataViewer_DragDrop);
            this.dataViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataViewer_DragEnter);
            // 
            // splitContainer_rightProps
            // 
            this.splitContainer_rightProps.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer_rightProps.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitContainer_rightProps.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_rightProps.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_rightProps.Name = "splitContainer_rightProps";
            this.splitContainer_rightProps.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_rightProps.Panel1
            // 
            this.splitContainer_rightProps.Panel1.Controls.Add(this.statusGridView);
            this.splitContainer_rightProps.Panel1MinSize = 55;
            // 
            // splitContainer_rightProps.Panel2
            // 
            this.splitContainer_rightProps.Panel2.Controls.Add(this.urOptionsGrid);
            this.splitContainer_rightProps.Panel2MinSize = 0;
            this.splitContainer_rightProps.Size = new System.Drawing.Size(300, 524);
            this.splitContainer_rightProps.SplitterDistance = 150;
            this.splitContainer_rightProps.TabIndex = 74;
            // 
            // statusGridView
            // 
            this.statusGridView.AllowUserToAddRows = false;
            this.statusGridView.AllowUserToDeleteRows = false;
            this.statusGridView.AllowUserToResizeColumns = false;
            this.statusGridView.AllowUserToResizeRows = false;
            this.statusGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.statusGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.statusGridView.ColumnHeadersHeight = 20;
            this.statusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.statusGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusGridView.DefaultCellStyle = dataGridViewCellStyle16;
            this.statusGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.statusGridView.EnableHeadersVisualStyles = false;
            this.statusGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusGridView.Location = new System.Drawing.Point(0, 0);
            this.statusGridView.MultiSelect = false;
            this.statusGridView.Name = "statusGridView";
            this.statusGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.statusGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.statusGridView.RowHeadersVisible = false;
            this.statusGridView.RowHeadersWidth = 130;
            this.statusGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusGridView.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.statusGridView.RowTemplate.Height = 17;
            this.statusGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.statusGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.statusGridView.Size = new System.Drawing.Size(300, 150);
            this.statusGridView.TabIndex = 70;
            this.statusGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusGridView_CellCmbxValueChanged);
            this.statusGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.statusGridView_CurrentCellDirtyStateChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 104;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 50;
            // 
            // urOptionsGrid
            // 
            this.urOptionsGrid.BackColor = System.Drawing.SystemColors.Control;
            this.urOptionsGrid.CommandsBorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.urOptionsGrid.CommandsVisibleIfAvailable = false;
            this.urOptionsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urOptionsGrid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urOptionsGrid.HelpBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.urOptionsGrid.LineColor = System.Drawing.SystemColors.ControlLight;
            this.urOptionsGrid.Location = new System.Drawing.Point(0, 0);
            this.urOptionsGrid.Name = "urOptionsGrid";
            this.urOptionsGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.urOptionsGrid.Size = new System.Drawing.Size(300, 370);
            this.urOptionsGrid.TabIndex = 66;
            this.urOptionsGrid.ToolbarVisible = false;
            this.urOptionsGrid.UseCompatibleTextRendering = true;
            this.urOptionsGrid.ViewBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.urOptionsGrid.ViewBorderColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // SectionsControl
            // 
            this.SectionsControl.Controls.Add(this.tabExcel);
            this.SectionsControl.Controls.Add(this.tabMicrogeneration);
            this.SectionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionsControl.Location = new System.Drawing.Point(0, 24);
            this.SectionsControl.Multiline = true;
            this.SectionsControl.Name = "SectionsControl";
            this.SectionsControl.SelectedIndex = 0;
            this.SectionsControl.Size = new System.Drawing.Size(1211, 617);
            this.SectionsControl.TabIndex = 76;
            this.SectionsControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.SectionsControl_Selected);
            // 
            // buttonBackground
            // 
            this.buttonBackground.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBackground.ColumnCount = 1;
            this.buttonBackground.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonBackground.Controls.Add(this.appInfo, 0, 0);
            this.buttonBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBackground.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.buttonBackground.Location = new System.Drawing.Point(0, 641);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.RowCount = 1;
            this.buttonBackground.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonBackground.Size = new System.Drawing.Size(1211, 25);
            this.buttonBackground.TabIndex = 78;
            // 
            // contextMenuOpenTable
            // 
            this.contextMenuOpenTable.Name = "contextMenuOpenTable";
            this.contextMenuOpenTable.ShowItemToolTips = false;
            this.contextMenuOpenTable.Size = new System.Drawing.Size(61, 4);
            // 
            // imgListData
            // 
            this.imgListData.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListData.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListData.ImageStream")));
            this.imgListData.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListData.Images.SetKeyName(0, "ShowDataPreview.png");
            this.imgListData.Images.SetKeyName(1, "SummaryView.png");
            this.imgListData.Images.SetKeyName(2, "SwitchToPreview.png");
            this.imgListData.Images.SetKeyName(3, "DataSourceView.png");
            this.imgListData.Images.SetKeyName(4, "GridDetailView.png");
            this.imgListData.Images.SetKeyName(5, "TableGroup.png");
            this.imgListData.Images.SetKeyName(6, "ResultsToGrid.png");
            this.imgListData.Images.SetKeyName(7, "GridDetailView.png");
            this.imgListData.Images.SetKeyName(8, "SaveTable.png");
            this.imgListData.Images.SetKeyName(9, "TableOK.png");
            this.imgListData.Images.SetKeyName(10, "TableMissing.png");
            this.imgListData.Images.SetKeyName(11, "TableGroupError.png");
            this.imgListData.Images.SetKeyName(12, "TableError.png");
            this.imgListData.Images.SetKeyName(13, "AddTable.png");
            this.imgListData.Images.SetKeyName(14, "DeleteTable.png");
            this.imgListData.Images.SetKeyName(15, "SelectTable.png");
            this.imgListData.Images.SetKeyName(16, "OpenFolder.png");
            this.imgListData.Images.SetKeyName(17, "OpenProjectFolder.png");
            this.imgListData.Images.SetKeyName(18, "FolderOpened.png");
            this.imgListData.Images.SetKeyName(19, "SearchFolderOpened.png");
            this.imgListData.Images.SetKeyName(20, "SamplesFolder.png");
            this.imgListData.Images.SetKeyName(21, "StorageContainer.png");
            this.imgListData.Images.SetKeyName(22, "StorageContainerGroup.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1211, 666);
            this.Controls.Add(this.SectionsControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonBackground);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "dataEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RowContext.ResumeLayout(false);
            this.propGrid_stripMenu.ResumeLayout(false);
            this.CellContext.ResumeLayout(false);
            this.ColumnContext.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMicrogeneration.ResumeLayout(false);
            this.tabMicrogeneration.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.mgSplitContainer_vertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_vertical)).EndInit();
            this.mgSplitContainer_vertical.ResumeLayout(false);
            this.mgSplitContainer_horizontal.Panel1.ResumeLayout(false);
            this.mgSplitContainer_horizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_horizontal)).EndInit();
            this.mgSplitContainer_horizontal.ResumeLayout(false);
            this.upperTableLayoutMainData.ResumeLayout(false);
            this.upperTableLayoutMainData.PerformLayout();
            this.tabControlCurrentProject.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.mgSplitContainer_insideHorizontal.Panel1.ResumeLayout(false);
            this.mgSplitContainer_insideHorizontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_insideHorizontal)).EndInit();
            this.mgSplitContainer_insideHorizontal.ResumeLayout(false);
            this.mgSplitContainer_inside_vertical.Panel1.ResumeLayout(false);
            this.mgSplitContainer_inside_vertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_inside_vertical)).EndInit();
            this.mgSplitContainer_inside_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgDataViewer)).EndInit();
            this.mgSplitContainer_insideRight.Panel1.ResumeLayout(false);
            this.mgSplitContainer_insideRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgSplitContainer_insideRight)).EndInit();
            this.mgSplitContainer_insideRight.ResumeLayout(false);
            this.groupBoxRes.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.inputTableLoyaut.ResumeLayout(false);
            this.inputTableLoyaut.PerformLayout();
            this.mgToolStripInputData.ResumeLayout(false);
            this.mgToolStripInputData.PerformLayout();
            this.tabExcel.ResumeLayout(false);
            this.tabExcel.PerformLayout();
            this.urToolStrip.ResumeLayout(false);
            this.urToolStrip.PerformLayout();
            this.splitContainer_bigMain.Panel1.ResumeLayout(false);
            this.splitContainer_bigMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_bigMain)).EndInit();
            this.splitContainer_bigMain.ResumeLayout(false);
            this.splitContainer_dataGrids.Panel1.ResumeLayout(false);
            this.splitContainer_dataGrids.Panel1.PerformLayout();
            this.splitContainer_dataGrids.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_dataGrids)).EndInit();
            this.splitContainer_dataGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewer)).EndInit();
            this.splitContainer_rightProps.Panel1.ResumeLayout(false);
            this.splitContainer_rightProps.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_rightProps)).EndInit();
            this.splitContainer_rightProps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusGridView)).EndInit();
            this.SectionsControl.ResumeLayout(false);
            this.buttonBackground.ResumeLayout(false);
            this.buttonBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip RowContext;
        private ToolStripMenuItem RightClick_HeadsRow;
        private ToolStripMenuItem RightClick_FirstRowData;
        private ContextMenuStrip CellContext;
        private ContextMenuStrip ColumnContext;
        private ToolStripMenuItem setAsColumn4CheckToolStripMenuItem;
        private ToolStripMenuItem setAsStaticValueToolStripMenuItem;
        private FontDialog fontDialog1;
        private ContextMenuStrip propGrid_stripMenu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem importXMLToolStripMenuItem;
        private ToolStripMenuItem OptionsMenu;
        private ToolStripMenuItem showConsoleToolStripMenuItem;
        private ToolStripMenuItem closeAllExcelsToolStripMenuItem;
        private ToolStripMenuItem universalReaderToolStripMenu;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem MenuAbout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem regLibOfficeToolStripMenuItem;
        private ToolStripMenuItem xFAReaderToolStripMenuItem;
        private ToolStripMenuItem ExitUR;
        private TabPage tabMicrogeneration;
        private ToolStrip g;
        private ToolStripSplitButton mgBtnImportFile;
        private ToolStripButton toolBtnDictionaryList;
        private ToolStripButton toolBtnDictionaryEditor;
        private ToolStripSeparator toolStripButton3;
        private ToolStripComboBox toolBtnMounth;
        private ToolStripComboBox toolBtnYear;
        private ToolStripSeparator toolStripButton4;
        private SplitContainer mgSplitContainer_vertical;
        private SplitContainer mgSplitContainer_horizontal;
        private TextBox textBoxNameGP;
        private Label lblNameGP;
        private TextBox textBoxGTPcode;
        private Label lblSubject;
        private TextBox textBoxSubject;
        private Label lblGTPcode;
        private SplitContainer mgSplitContainer_insideHorizontal;
        private TreeView datsTreeView;
        private TabPage tabExcel;
        private ToolStrip urToolStrip;
        private ToolStripSplitButton urBtnImportFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton urBtnSaveXML;
        private ToolStripButton urBtnConvert2Tree;
        private SplitContainer splitContainer_bigMain;
        private SplitContainer splitContainer_dataGrids;
        private TextBox CellViewer;
        private SplitContainer splitContainer_rightProps;
        private StatusGridViewEditMode statusGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ToolStripButton mgBtnOpenFolder;
        private ToolStripButton mgBtnSaveDats;
        private ToolStripSeparator toolStripSeparator4;
        private FlowLayoutPanel mgFlowPanelResult;
        private ToolStripButton mgBtnNewProject;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton mgBtnOpenFile;
        private ToolStripButton toolBtnConvertFile;
        private ToolStripButton mgOpenDataTable;
        private ToolStripButton mgDataСalculation;
        private ToolStripButton mgDataAct;
        private DoubleBufferedDataGridView mgDataViewer;
        private DoubleBufferedDataGridView dataViewer;
        private Label appInfo;
        private TableLayoutPanel buttonBackground;
        private TableLayoutPanel inputTableLoyaut;
        private ToolStrip mgToolStripInputData;
        private ToolStripSplitButton mgBtnEntryDatFiles;
        private ToolStripMenuItem mgFileSPUNC;
        private ToolStripMenuItem mgFileSVNC;
        private ToolStripMenuItem mgFileKF;
        private ToolStripButton mgFileSPUNCbtn;
        private ToolStripButton mgFileSVNCbtn;
        private ToolStripButton mgFileKFbtn;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private SplitContainer mgSplitContainer_inside_vertical;
        public PropertyGrid urOptionsGrid;
        private ToolStripButton imgStatusOk;
        private ToolStripButton imgStatusDwnld;
        private ToolStripButton imgStatusFailed;
        private SplitContainer mgSplitContainer_insideRight;
        private TreeView ResourcesTreeView;
        private GroupBox groupBoxRes;
        private GroupBox groupBoxData;
        private ContextMenuStrip contextMenuOpenTable;
        private ImageList imgList;
        public TabControl SectionsControl;
        private ImageList imgListData;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataTable;
        private DataGridViewTextBoxColumn Agreement;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn DateAgreement;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn TariffZone;
        private DataGridViewTextBoxColumn NumCC;
        private DataGridViewTextBoxColumn REC;
        private DataGridViewTextBoxColumn GEN;
        private DataGridViewTextBoxColumn SELL;
        private DataGridViewTextBoxColumn BUY;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn dataCalculation;
        private DataGridViewTextBoxColumn dataAct;
        private DataGridViewTextBoxColumn OpenFolder;
        private TabControl tabControlCurrentProject;
        private TabPage tabBasic;
        private TabPage tabDetail;
        private TableLayoutPanel upperTableLayoutMainData;
        private Label lblMainName;
    }
}