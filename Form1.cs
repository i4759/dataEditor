using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using static dataEditor.Program;
using System.IO;
using System.Xml;
using System.Data.OleDb;
using Excel=Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Diagnostics.Tracing;
using System.Xml.Linq;
using System;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.DirectoryServices.ActiveDirectory;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Drawing.Imaging;
using System.Linq;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace dataEditor
{

    public partial class MainForm : Form
    {
        Version OsMinVersion = new Version(10, 0, 15063, 0);

        iniFile INI = new iniFile("config.ini");
        Form TreeView = new Form();
        Form TableView = new Form();
        TextBox TextExtractColumns = new TextBox();
        DataGridView TreeColViewer = new DataGridView();
        DataSet UniversalDataSet = new DataSet("UniversalFileReader");
        Button ConfirmCols = new Button();

        int cntShows = 0;
        int HFR = 0;
        int prvCntHedRw = 2;
        int RowsCnt = 0;
        bool allowVoid = false;
        bool lockVoid = false;


        CheckBox headerCheckBox = new CheckBox();
        DataGridViewCell ActiveCell = null;
        DataGridViewColumn ActiveColumn = null;

        XElement strID = null;
        XElement extraColumns = null;
        XElement headsRow = null;
        XElement firstData = null;
        XElement columnsCount = null;

        int[] obj1 = new int[] { };
        string xmlFileName = "";
        string ExlFileName = null;
        List<int> tempPropVal = new List<int>() { };
        List<Color> tempPropColors = new List<Color>() { };
        List<String> SQLdata = new List<string>() { };
        String[] SQLdbTemp = { };
        String[] SQLdbTempB = { };
        String[] SQLdbTempC = { };

        DataTable dt_db_shema = new DataTable();

        PropertySet PropGrid;
        Color fntCl = Color.Black;
        Color fntClDat = Color.Black;
        Color fntTreeCl = Color.Black;
        Color fntClStaticDat = Color.Black;



        private const int MF_BYCOMMAND = 0x00000000;
        public const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = false)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        public class StatusGridViewEditMode : DataGridView
        {
            protected override bool ProcessDialogKey(Keys keyData)
            {
                if (keyData == Keys.Enter)
                    return base.ProcessDialogKey(Keys.Tab);
                else
                    return base.ProcessDialogKey(keyData);
            }
            protected override bool ProcessDataGridViewKey(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    return this.ProcessRightKey(e.KeyData);
                }
                return base.ProcessDataGridViewKey(e);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            LoadListName();
            AllocConsole();
            Magician.DisappearConsole();
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
        }

        public static void ScaleControlElements(DataGridView ScaleSource, SizeF ScaleFactor)
        {
            foreach (DataGridViewColumn Column in ScaleSource.Columns)
            {
                Column.Width = (int)Math.Round(Column.Width * ScaleFactor.Width);
            }
        }

        public static void ScaleControlElements(ListView ScaleSource, SizeF ScaleFactor)
        {
            foreach (ColumnHeader Column in ScaleSource.Columns)
            {
                Column.Width = (int)Math.Round(Column.Width * ScaleFactor.Width);
            }
        }

        protected override void ScaleControl(SizeF ScalingFactor, BoundsSpecified Bounds)
        {
            base.ScaleControl(ScalingFactor, Bounds);
            ScaleControlElements(dataViewer, ScalingFactor);
            Console.WriteLine("DPI scaling enabled");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SettingsNewForm();
            PropGrid = new PropertySet();
            optionsGrid.SelectedObject = PropGrid;
            PropGrid.sqlNames = "Name;Dat8;Type;Is_fact;OAO;GTP_Kod;GTP;Nomer_Dog;Kontragent;K_GTP_Kod;K_GTP;Dog_V;V;S;S_NDS";
            TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["ExtraColCnt"].SetReadOnlyAttribute(true);
            Console.WriteLine(Environment.OSVersion.Platform.ToString());
            Console.WriteLine(Environment.OSVersion.VersionString + " (" + AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName + ") " + Environment.OSVersion.Version.CompareTo(OsMinVersion));
            Console.WriteLine("Soft powered by 47 5'9 (ver. " + PropGrid.AppVersion + ") //.build for GitHub");
            ReadINI();
            AutoFillList();
            CheckRegLib();

            tempPropColors.Add(PropGrid.ColorHeads);
            tempPropColors.Add(PropGrid.ColorDataRows);
            tempPropColors.Add(PropGrid.ColorStaticDat);
            tempPropColors.Add(PropGrid.SecondColorHeads);
        }

        private void statusGridView_CellCmbxValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in statusGridView.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Cells[2].Value = "ok";
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                else
                {
                    row.Cells[2].Value = "";
                    row.DefaultCellStyle.BackColor = Color.Empty;
                    statusGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                }
            }
        }

        private void statusGridView_MouseClick(Object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hittestinfo = statusGridView.HitTest(e.X, e.Y);
                if (hittestinfo != null && hittestinfo.Type == DataGridViewHitTestType.Cell)
                {
                    if (statusGridView.Rows[hittestinfo.RowIndex].Cells[2].Value == "ok")
                        {
                            statusGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 91, 201, 91);
                        }
                    else
                        {
                            statusGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                        }
                }
        }

        private void statusGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (statusGridView.Rows[statusGridView.CurrentCellAddress.Y].Cells[statusGridView.CurrentCellAddress.X].Value != null)
            {
                statusGridView.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            }
        }

        private void statusGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataViewer.DataSource != null && statusGridView.Rows[2].Cells[1].Value != null && statusGridView.CurrentCellAddress.X == 1 && statusGridView.CurrentCellAddress.Y == 2)
            {
                foreach (DataGridViewRow rws in dataViewer.Rows)
                {
                    if (rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads | rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads)
                    {
                        rws.DefaultCellStyle.BackColor = Color.Empty;
                        rws.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                if (Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value) > 0)
                {
                    HFR = Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value);
                    dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value) - 1].DefaultCellStyle.BackColor = PropGrid.ColorHeads;
                    dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value) - 1].DefaultCellStyle.ForeColor = fntCl;

                    if (PropGrid.DRow == true)
                    {
                        for (int i = 1; i < Convert.ToInt32(PropGrid.cntHeadsRows); i++)
                        {
                            dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value) - 1 + i].DefaultCellStyle.BackColor = PropGrid.ColorHeads;
                            dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value) - 1 + i].DefaultCellStyle.ForeColor = fntCl;
                        }
                    }
                }
                TreeFormDestroyer();
                dataViewer.ClearSelection();
                optionsGrid.Refresh();
            }

            if (dataViewer.DataSource != null && statusGridView.Rows[3].Cells[1].Value != null && statusGridView.CurrentCellAddress.X == 1 && statusGridView.CurrentCellAddress.Y == 3 || statusGridView.CurrentCellAddress.Y == 4)
            {
                foreach (DataGridViewRow row in dataViewer.Rows)
                {
                    if (row.DefaultCellStyle.BackColor == PropGrid.ColorDataRows | row.DefaultCellStyle.BackColor == PropGrid.ColorDataRows)
                    {
                        row.DefaultCellStyle.BackColor = Color.Empty;
                        row.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }

                if (Convert.ToInt32(statusGridView.Rows[3].Cells[1].Value) > 0)
                {
                    dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[3].Cells[1].Value)-1].DefaultCellStyle.BackColor = PropGrid.ColorDataRows;
                    dataViewer.Rows[Convert.ToInt32(statusGridView.Rows[3].Cells[1].Value)-1].DefaultCellStyle.ForeColor = fntClDat;

                    for (int i = (Convert.ToInt32(statusGridView.Rows[3].Cells[1].Value)-1 + Convert.ToInt32(statusGridView.Rows[4].Cells[1].Value) + 1); i < RowsCnt; i += Convert.ToInt32(statusGridView.Rows[4].Cells[1].Value) + 1)
                    {
                        if (dataViewer.Rows[i].Cells[1].Value != DBNull.Value)
                        {
                            dataViewer.Rows[i].DefaultCellStyle.BackColor = PropGrid.ColorDataRows;
                            dataViewer.Rows[i].DefaultCellStyle.ForeColor = fntClDat;
                        }
                    }
                }
                dataViewer.ClearSelection();
                optionsGrid.Refresh();
            }
        }

        private void AutoFillList()
        {
            SQLdata.Clear();
            string[] subs = PropGrid.sqlNames.Split(';');
            SQLdbTemp = subs;
            SQLdbTempB = subs;

            foreach (var sub in subs)
            {
                if (sub != "")
                {
                    //Console.WriteLine($"Find SQL link: {sub}");
                    SQLdata.Add(sub);
                }
            }
        }

        private void ReadINI()
        {
            if (File.Exists(Environment.CurrentDirectory + "\\config.ini"))
            {
                Console.WriteLine("Config.ini found, all settings loaded successfully.");

                if (INI.KeyExists("SQLNamesList", "SQL"))
                {
                    PropGrid.sqlNames = INI.ReadINI("SQL", "SQLNamesList");
                }
                if (INI.KeyExists("ColorHeaders", "Visuals"))
                {
                    PropGrid.ColorHeads = Color.FromName(INI.ReadINI("Visuals", "ColorHeaders"));
                }
                if (INI.KeyExists("ColorHeaders(ListView)", "Visuals"))
                {
                    PropGrid.SecondColorHeads = Color.FromName(INI.ReadINI("Visuals", "ColorHeaders(ListView)"));
                }
                if (INI.KeyExists("ColorDataRows", "Visuals"))
                {
                    PropGrid.ColorDataRows = Color.FromName(INI.ReadINI("Visuals", "ColorDataRows"));
                }
                if (INI.KeyExists("ColorStaticCell", "Visuals"))
                {
                    PropGrid.ColorStaticDat = Color.FromName(INI.ReadINI("Visuals", "ColorStaticCell"));
                }
                if (INI.KeyExists("ForceCloseAllExcel", "Other"))
                {
                    PropGrid.ForceCloseExl = bool.Parse(INI.ReadINI("Other", "ForceCloseAllExcel"));
                }
                autoFontColor();
                optionsGrid.Refresh();
            }
            else
            {
                Console.WriteLine("Config.ini file not found, all settings was loaded with default values.");
            }
        }

        private void ConfigUpdater_handle()
        {
            INI.Write("SQL", "SQLNamesList", PropGrid.sqlNames.ToString());
            INI.Write("Visuals", "ColorHeaders", PropGrid.ColorHeads.Name.ToString());
            INI.Write("Visuals", "ColorHeaders(ListView)", PropGrid.SecondColorHeads.Name.ToString());
            INI.Write("Visuals", "ColorDataRows", PropGrid.ColorDataRows.Name.ToString());
            INI.Write("Visuals", "ColorStaticCell", PropGrid.ColorStaticDat.Name.ToString());
            INI.Write("Other", "ForceCloseAllExcel", PropGrid.ForceCloseExl.ToString());
        }

        public void ConfigUpdater()
        {
            GridItemCollection categories;
            if (optionsGrid.SelectedGridItem.GridItemType == GridItemType.Category)
            {
                categories = optionsGrid.SelectedGridItem.Parent.GridItems;
            }
            else
            {
                categories = optionsGrid.SelectedGridItem.Parent.Parent.GridItems;
            }

            foreach (var category in categories)
            {
                if (((GridItem)category).GridItemType == GridItemType.Category)
                {
                    foreach (GridItem gi in ((GridItem)category).GridItems)
                    {
                        if (gi.Label.ToString() != "AvailableXML" && gi.Parent.Label.ToString() != "App" && gi.Parent.Label.ToString() != "Visuals")
                        {
                            INI.Write(gi.Parent.Label.ToString(), gi.Label.ToString(), gi.Value.ToString());
                        }
                        if(gi.Parent.Label.ToString() == "Visuals")
                        {
                            var str1 = gi.Value.ToString();
                            string[] strs = str1.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                            INI.Write(gi.Parent.Label.ToString(), gi.Label.ToString(), strs[1].ToString());
                        }
                    }
                }
            }
        }

        private void OnProcessExit(object sender, EventArgs e)
        {
            if (PropGrid.ForceCloseExl == true)
            {
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.Equals("EXCEL"))
                    {
                        clsProcess.Kill();
                        //break;
                    }
                }
            }
            else
            {
                KillSpecificExcelFileProcess(ExlFileName);
            }
        }

        private void CloseAllExcel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This process forcibly terminates all Excel program processes.\nYou are sure?\n", "dataEditor closer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (Process clsProcess in Process.GetProcesses())
                {
                    if (clsProcess.ProcessName.Equals("EXCEL"))
                    {
                        clsProcess.Kill();
                        //break;
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void KillSpecificExcelFileProcess(string excelFileName)
        {
            var processes = from p in Process.GetProcessesByName("EXCEL")
                            select p;

            foreach (var process in processes)
            {
                if (process.MainWindowTitle == "Microsoft Excel - " + excelFileName)
                    process.Kill();
            }
        }

        private void DataViewer_CheckClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataViewer.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                HFR = e.RowIndex + 1;
                statusGridView.Rows[2].Cells[1].Value = Convert.ToInt32(dataViewer.Rows[e.RowIndex].HeaderCell.Value.ToString().Split(' ').Last());
                dataViewer.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                RightClick_HeadsRow.Enabled = true;
                Convert2Tree.Visible = true;
                if (PropGrid.DRow == true)
                {
                    dataViewer.Rows[e.RowIndex + 1].DefaultCellStyle.BackColor = Color.PowderBlue;
                    dataViewer.Rows[e.RowIndex + 1].Cells[0].Value = true;
                    RightClick_HeadsRow.Enabled = true;
                    Convert2Tree.Visible = true;
                }
            }
            optionsGrid.Refresh();
        }

        private void DataViewer_ColumnsSelected(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataViewer.ClearSelection();
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex > -1 && e.RowIndex == -1)
                {
                    //dataViewer.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
                    //dataViewer.Columns[e.ColumnIndex].Selected = true;
                    ColumnContext.Show(Cursor.Position);
                    statusGridView.Rows[6].Cells[1].Value += dataViewer.Columns[e.ColumnIndex].Name.ToString() + ";";
                    optionsGrid.Refresh();
                }
            }
        }

        private void DataViewer_RowSelected(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataViewer.ClearSelection();

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex == -1 && e.RowIndex > -1)
                {
                    dataViewer.Rows[e.RowIndex].Selected = true;
                    ActiveCell = dataViewer[0, e.RowIndex];
                    RowContext.Show(Cursor.Position);
                }
            }
        }

        private void DataViewer_SwitchCheckRow(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                int cllc = 0;
                foreach (DataGridViewRow row in dataViewer.Rows)
                {
                    row.Cells[0].Value = false;
                }

                foreach (DataGridViewRow row in dataViewer.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (Convert.ToBoolean(row.Cells[0].EditedFormattedValue) == true)
                    {
                        cllc++;
                    }
                    if (Convert.ToBoolean(row.Cells[0].EditedFormattedValue) == false)
                    {
                        chk.FlatStyle = FlatStyle.Flat;
                        chk.Style.ForeColor = Color.DarkGray;
                        chk.ReadOnly = true;
                    }
                }

                foreach (DataGridViewRow row in dataViewer.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    if (cllc == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Empty;
                        chk.FlatStyle = FlatStyle.Standard;
                        chk.Style.ForeColor = Color.White;
                        chk.ReadOnly = false;
                    }
                }


                if (cllc != 0)
                {
                    RightClick_HeadsRow.Enabled = true;
                    Convert2Tree.Visible = true;
                }
                else
                {
                    Convert2Tree.Visible = false;
                    RightClick_HeadsRow.Enabled = false;
                }
            }

        }

        private void dataViewer_MouseClick(Object sender, MouseEventArgs e)
        {
            dataViewer.ClearSelection();

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                System.Windows.Forms.DataGridView.HitTestInfo hittestinfo = dataViewer.HitTest(e.X, e.Y);
                if (hittestinfo != null && hittestinfo.Type == DataGridViewHitTestType.Cell)
                {
                    ActiveCell = dataViewer.Rows[hittestinfo.RowIndex].Cells[hittestinfo.ColumnIndex];
                    ActiveCell.Selected = true;
                    (CellContext.Items[0] as ToolStripMenuItem).DropDownItems.Clear();
                    foreach (string s in SQLdbTempB)
                    {
                        (CellContext.Items[0] as ToolStripMenuItem).DropDownItems.Add(s, null, cellStripSubMenu_Click);
                    }
                    if (dataViewer.Rows[ActiveCell.RowIndex].Cells[ActiveCell.ColumnIndex].Value != DBNull.Value)
                        CellContext.Show(dataViewer, new Point(e.X, e.Y));
                }
            }

        }

        private void cellStripSubMenu_Click(object sender, EventArgs e)
        {
            if (dataViewer.Rows[ActiveCell.RowIndex].Cells[ActiveCell.ColumnIndex].Value != DBNull.Value) 
            {
                dataViewer.ClearSelection();

                var clickedMenuItem = sender as ToolStripMenuItem;
                var menuText = clickedMenuItem.Text;
                

                dataViewer.Rows[ActiveCell.RowIndex].Cells[ActiveCell.ColumnIndex].Value += " [" + clickedMenuItem.Text + "]";
                dataViewer.Rows[ActiveCell.RowIndex].Cells[ActiveCell.ColumnIndex].Style.BackColor = PropGrid.ColorStaticDat;
                dataViewer.Rows[ActiveCell.RowIndex].Cells[ActiveCell.ColumnIndex].Style.ForeColor = fntClStaticDat;

                SQLdbTempB = Array.FindAll(SQLdbTemp, i => i != clickedMenuItem.Text.ToString()).ToArray();
                SQLdbTempC = SQLdbTempC.Append(clickedMenuItem.Text.ToString()).ToArray();
                SQLdbTemp = SQLdbTempB;


                Console.WriteLine("Selected static Value - " + "columns: " + (ActiveCell.ColumnIndex + 1).ToString() + " // attach to SQL: " + menuText.ToString());
            }
            else
            {
                MessageBox.Show("This cell is empty and cannot using for extract values.");
            }
        }

        private void cellStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void Convert2Tree_Click(object sender, EventArgs e)
        {
            if (cntShows != 0)
            {
                SendKeys.Send("{LEFT}");
                TreeColViewer_CellCmbxValueChanged(this.TreeColViewer, new DataGridViewCellEventArgs(this.TreeColViewer.CurrentCell.ColumnIndex, this.TreeColViewer.CurrentRow.Index));
                TreeView.ShowDialog();
                return;
            }


            DataGridViewTextBoxColumn Col1 = new DataGridViewTextBoxColumn();
            Col1.Width = 400;
            Col1.Name = "Columns names";
            TreeColViewer.Columns.Add(Col1);
            TreeColViewer.AllowUserToAddRows = false;
            TreeColViewer.AllowUserToDeleteRows = false;


            foreach (DataGridViewColumn column in TreeColViewer.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < dataViewer.Columns.Count; i++)
            {
                int rc = TreeColViewer.RowCount;
                int HVC = 0;

                if (PropGrid.DRow == true)
                {
                    for (int j = (Convert.ToInt32(HFR) - 1); j < ((Convert.ToInt32(HFR) - 1) + Convert.ToInt32(PropGrid.cntHeadsRows)); j++)
                    {
                        if (dataViewer.Rows[j].Cells[i].Value != DBNull.Value)
                        {
                            TreeColViewer.Rows.Add();
                            TreeColViewer.Rows[rc].Cells[0].Value = dataViewer.Rows[j].Cells[i].Value;
                            HVC++;
                            if (HVC >= 2)
                            {
                                TreeColViewer.Rows[rc].HeaderCell.Value = "";
                            }
                            else
                            {
                                TreeColViewer.Rows[rc].HeaderCell.Value = "F" + (i + 1);
                            }
                            rc++;
                        }
                    }
                }
                else
                {
                    if (dataViewer.Rows[Convert.ToInt32(HFR) - 1].Cells[i].Value != DBNull.Value)
                    {
                        TreeColViewer.Rows.Add();
                        TreeColViewer.Rows[rc].HeaderCell.Value = "F" + (i + 1);
                        TreeColViewer.Rows[rc].Cells[0].Value = dataViewer.Rows[Convert.ToInt32(HFR) - 1].Cells[i].Value;
                    }
                }
            }

            foreach (DataGridViewRow row in TreeColViewer.Rows)
            {
                if (row.Cells[0].Value == DBNull.Value)
                {
                    TreeColViewer.Rows.RemoveAt(row.Index);
                }
            }


            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            DataGridViewComboBoxColumn bindColumn = new DataGridViewComboBoxColumn();
            checkBoxColumn.Width = 22;
            bindColumn.DataSource = SQLdata;
            bindColumn.Name = "Attachment to SQL columns";
            bindColumn.Width = 120;
            TreeColViewer.Columns.Insert(0, checkBoxColumn);
            TreeColViewer.Columns.Add(bindColumn);

            foreach (DataGridViewRow rw in TreeColViewer.Rows)
            {
                if (rw.HeaderCell.Value == "")
                {
                    rw.Cells[0] = new DataGridViewTextBoxCell();
                    rw.Cells[0].ReadOnly = true;
                    rw.Cells[0].Value = "";
                    rw.Cells[2] = new DataGridViewTextBoxCell();
                    rw.Cells[2].ReadOnly = true;
                    rw.Cells[2].Value = "";
                }
            }

            TreeColViewer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            Point headerCellLocation = TreeColViewer.GetCellDisplayRectangle(0, 0, true).Location;
            headerCheckBox.Location = new Point(headerCellLocation.X + (TreeColViewer.RowHeadersWidth + 5), headerCellLocation.Y + 5);
            headerCheckBox.BackColor = Color.White;
            headerCheckBox.Size = new Size(18, 18);
            headerCheckBox.Click += new EventHandler(HeaderCheckBox_Clicked);
            //TreeColViewer.Controls.Add(headerCheckBox);

            var TreeHeight = TreeColViewer.Rows.GetRowsHeight(DataGridViewElementStates.None) + TreeColViewer.ColumnHeadersHeight;
            var TreeWidth = TreeColViewer.Columns.GetColumnsWidth(DataGridViewElementStates.None) + TreeColViewer.RowHeadersWidth;

            if (TreeHeight > 640)
            {
                TreeHeight = 640;
                TreeWidth += 18;
                TreeColViewer.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                TreeColViewer.ScrollBars = ScrollBars.None;
            }

            TreeColViewer.Size = new Size(TreeWidth, TreeHeight);
            TextExtractColumns.Size = new Size(TreeWidth, 23);
            TreeView.Size = new Size(TreeWidth + 30, TreeHeight + 120);

            ConfirmCols.Location = new Point(5, TreeHeight + 45);
            ConfirmCols.Click += new EventHandler(ConfirmCols_Click);
            TreeView.Controls.Add(ConfirmCols);
            ConfirmCols.Enabled = false;

            TreeColViewer.Columns[1].ReadOnly = true;
            TreeColViewer.Columns[1].Resizable = DataGridViewTriState.False;
            TreeColViewer.Columns[2].ReadOnly = true;
            TreeColViewer.Columns[2].Resizable = DataGridViewTriState.False;

            TreeColViewer.CellContentClick += new DataGridViewCellEventHandler(ColumnsViewer_CheckClick);
            TreeColViewer.CurrentCellDirtyStateChanged += new EventHandler(TreeColViewer_CurrentCellDirtyStateChanged);
            TreeView.FormClosed += new System.Windows.Forms.FormClosedEventHandler(OnProcessExitTreeView);
            TreeColViewer.CellValueChanged += new DataGridViewCellEventHandler(TreeColViewer_CellCmbxValueChanged);

            allowVoid = true;
            cntShows++;

            TreeView.ShowDialog();
            optionsGrid.Refresh();

        }

        private void OnProcessExitTreeView(object sender, EventArgs e)
        {
            TreeColViewer_CellCmbxValueChanged(this.TreeColViewer, new DataGridViewCellEventArgs(this.TreeColViewer.CurrentCell.ColumnIndex, this.TreeColViewer.CurrentRow.Index));
            TreeView.Hide();
        }

        private void TreeColViewer_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = TreeColViewer.Columns[TreeColViewer.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                SendKeys.Send("{LEFT}");
            }
        }

        private void TreeColViewer_CellCmbxValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (allowVoid == true) {
                string[] SQLdataTemp = PropGrid.sqlNames.Split(';');


                foreach (var delItem in SQLdbTempC)
                {
                    SQLdataTemp = Array.FindAll(SQLdataTemp, i => i != delItem.ToString()).ToArray();
                }

                foreach (DataGridViewRow rwcb in TreeColViewer.Rows)
                {
                    if (rwcb.Cells[2] is DataGridViewComboBoxCell && rwcb.Cells[2].Value != null)
                    {
                        SQLdataTemp = Array.FindAll(SQLdataTemp, i => i != rwcb.Cells[2].Value.ToString()).ToArray();
                    }
                }

                SQLdbTemp = SQLdataTemp;

                foreach (DataGridViewRow rwcb in TreeColViewer.Rows)
                {
                    if (rwcb.Cells[2] is DataGridViewComboBoxCell)
                    {
                        if (rwcb.Cells[2].Value == null && rwcb.Cells[0].Value != "" && Convert.ToBoolean(rwcb.Cells[0].EditedFormattedValue) == true)
                        {
                            DataGridViewComboBoxCell cellSQL = new DataGridViewComboBoxCell();
                            cellSQL.DataSource = SQLdbTemp;
                            rwcb.Cells[2] = new DataGridViewComboBoxCell();
                            rwcb.Cells[2] = cellSQL;
                        }
                        if (rwcb.Cells[2].Value != null && rwcb.Cells[0].Value != "" && Convert.ToBoolean(rwcb.Cells[0].EditedFormattedValue) == true)
                        {
                            string[] SQLdbTempB = { };
                            SQLdbTempB = SQLdbTemp.Append(rwcb.Cells[2].Value.ToString()).ToArray();
                            DataGridViewComboBoxCell cellSQL = (DataGridViewComboBoxCell)rwcb.Cells[2];
                            cellSQL.DataSource = SQLdbTempB;
                        }
                    }
                }

                SQLdbTempB = SQLdbTemp;
            }
        }

        private void ConfirmCols_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dte = new DataTable();


            if (statusGridView.Rows[5].Cells[1].Value == null)
            {
                dt.TableName = "usedColumns";
                dte.TableName = "commonSettings";
                UniversalDataSet.Tables.Add(dt);
                UniversalDataSet.Tables.Add(dte);
            }

            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add(new DataColumn("name", typeof(string)));
            dt.Columns.Add(new DataColumn("link2SQL", typeof(string)));

            dte.Clear();
            dte.Columns.Add("extraColumns");
            dte.Columns.Add("headsRow");
            dte.Columns.Add("firstData");
            dte.Columns.Add("columnsCount");
            dte.Columns.Add("columnsCheck");



            int TagCounts = 0;

            statusGridView.Rows[5].Cells[1].Value = "";

            foreach (DataGridViewRow r in TreeColViewer.Rows)
            {
                if (r.Cells[0].Value != "" && Convert.ToBoolean(r.Cells[0].EditedFormattedValue))
                {
                    DataRow row = UniversalDataSet.Tables["usedColumns"].NewRow();
                    row["id"] = r.HeaderCell.Value.ToString().Split('F').Last();
                    row["name"] = r.Cells[1].Value;
                    row["link2SQL"] = r.Cells[2].Value;
                    UniversalDataSet.Tables["usedColumns"].Rows.Add(row);
                    statusGridView.Rows[5].Cells[1].Value += r.HeaderCell.Value.ToString().Split('F').Last() + ";";
                    TagCounts++;
                }
            }

            DataRow rwe = dte.NewRow();
            rwe["extraColumns"] = PropGrid.ExtraColCnt;
            rwe["headsRow"] = statusGridView.Rows[2].Cells[1].Value;
            rwe["firstData"] = statusGridView.Rows[3].Cells[1].Value;
            rwe["columnsCount"] = statusGridView.Rows[1].Cells[1].Value;
            rwe["columnsCheck"] = statusGridView.Rows[6].Cells[1].Value;
            dte.Rows.Add(rwe);

            TreeView.Hide();
            optionsGrid.Refresh();

            ExportXML.Enabled = true;
        }

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {

            TreeColViewer.EndEdit();
            TextExtractColumns.Text = "";

            if (headerCheckBox.Checked)
                ConfirmCols.Enabled = true;
            else
                ConfirmCols.Enabled = false;

            foreach (DataGridViewRow row in TreeColViewer.Rows)
            {
                DataGridViewCheckBoxCell checkBox = (row.Cells[0] as DataGridViewCheckBoxCell);
                if (row.Cells[0].Value != "")
                    checkBox.Value = headerCheckBox.Checked;

                if (row.Cells[0].Value != "" && Convert.ToBoolean(row.Cells[0].EditedFormattedValue))
                {
                    TextExtractColumns.Text += row.HeaderCell.Value + ";";
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Empty;
                }
            }

        }

        private void ColumnsViewer_CheckClick(object sender, DataGridViewCellEventArgs e)
        {
            allowVoid = false;

            TextExtractColumns.Text = "";

            int rowsChkCounts = 0;

            foreach (DataGridViewRow rw in TreeColViewer.Rows)
            {
                if (rw.Cells[2].Value != null && rw.Cells[0].Value != "" && Convert.ToBoolean(rw.Cells[0].EditedFormattedValue) == true)
                {
                    TextExtractColumns.Text += rw.HeaderCell.Value + ";";
                    rw.DefaultCellStyle.BackColor = PropGrid.SecondColorHeads;
                    rw.DefaultCellStyle.ForeColor = fntTreeCl;
                    rw.Cells[2].ReadOnly = false;
                    rowsChkCounts++;
                }
                if (rw.Cells[2].Value == null && rw.Cells[0].Value != "" && Convert.ToBoolean(rw.Cells[0].EditedFormattedValue) == true)
                {
                    DataGridViewComboBoxCell cellSQL = new DataGridViewComboBoxCell();
                    cellSQL.DataSource = SQLdbTemp;
                    TextExtractColumns.Text += rw.HeaderCell.Value + ";";
                    rw.DefaultCellStyle.BackColor = PropGrid.SecondColorHeads;
                    rw.DefaultCellStyle.ForeColor = fntTreeCl;
                    rw.Cells[2] = new DataGridViewComboBoxCell();
                    rw.Cells[2] = cellSQL;
                    rw.Cells[2].ReadOnly = false;
                    rowsChkCounts++;
                }
                if (rw.Cells[0].Value != "" && Convert.ToBoolean(rw.Cells[0].EditedFormattedValue) == false)
                {
                    DataGridViewComboBoxCell cellSQL = new DataGridViewComboBoxCell();
                    cellSQL.DataSource = SQLdata;
                    rw.Cells[2].Value = "";
                    rw.DefaultCellStyle.BackColor = Color.Empty;
                    rw.DefaultCellStyle.ForeColor = Color.Black;
                    rw.Cells[2] = new DataGridViewComboBoxCell();
                    rw.Cells[2] = cellSQL;
                    rw.Cells[2].ReadOnly = true;
                }
            }

            foreach (DataGridViewRow rws in TreeColViewer.Rows)
            {
                if (rws.Cells[0].Value != "" && Convert.ToBoolean(rws.Cells[0].EditedFormattedValue) == true)
                {
                    int rwtrue = rws.Index;
                    for (int n = rwtrue + 1; n < TreeColViewer.Rows.Count; n++)
                    {
                        if (TreeColViewer.Rows[n].HeaderCell.Value == "")
                        {
                            TreeColViewer.Rows[n].DefaultCellStyle.BackColor = Color.FromArgb(255, PropGrid.SecondColorHeads.R / 2, PropGrid.SecondColorHeads.G / 2, PropGrid.SecondColorHeads.B / 2);
                            if (PropGrid.SecondColorHeads.R / 2 < 120 | PropGrid.SecondColorHeads.G / 2 < 120 | PropGrid.SecondColorHeads.B / 2 < 120)
                                TreeColViewer.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else
                            break;
                    }
                }
                if (rws.Cells[0].Value != "" && Convert.ToBoolean(rws.Cells[0].EditedFormattedValue) == false)
                {
                    int rwfalse = rws.Index;
                    for (int n = rwfalse + 1; n < TreeColViewer.Rows.Count; n++)
                    {
                        if (TreeColViewer.Rows[n].HeaderCell.Value == "")
                        {
                            TreeColViewer.Rows[n].DefaultCellStyle.BackColor = Color.Empty;
                            TreeColViewer.Rows[n].DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                            break;
                    }
                }
                foreach (DataGridViewRow rw in TreeColViewer.Rows)
                {
                    if (rowsChkCounts >= SQLdata.Count + PropGrid.ExtraColCnt && rw.Cells[0].Value != "" && Convert.ToBoolean(rw.Cells[0].EditedFormattedValue) == false)
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)rw.Cells[0];
                        chk.FlatStyle = FlatStyle.Flat;
                        chk.Style.ForeColor = Color.DarkGray;
                        chk.ReadOnly = true;
                    }
                    if (rowsChkCounts < SQLdata.Count + PropGrid.ExtraColCnt && rw.Cells[0].Value != "")
                    {
                        DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)rw.Cells[0];
                        chk.FlatStyle = FlatStyle.Standard;
                        chk.Style.ForeColor = Color.White;
                        chk.ReadOnly = false;
                    }
                }

            }
            if (rowsChkCounts > 0)
                ConfirmCols.Enabled = true;
            else
                ConfirmCols.Enabled = false;

            allowVoid = true;
        }

        private void ExportXML_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.Filter = "XML File (*.xml*)|*.xml*";
            sfd.Title = "Save as XML";
            sfd.FileName = FormName.Text.ToString() + ".xml";


            if (statusGridView.Rows[1].Cells[1].Value != null && statusGridView.Rows[5].Cells[1].Value != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    string xlFileName = sfd.FileName;

                    try
                    {
                        //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                        UniversalDataSet.WriteXml(xlFileName.ToString());
                        BackUserMessanger.BackColor = Color.LightGreen;
                    }
                    catch
                    {
                        BackUserMessanger.BackColor = Color.IndianRed;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, fill in all the necessary data");
            }
        }

        private void ShowConsole_Click(object sender, EventArgs e)
        {
            if (showConsoleToolStripMenuItem.Checked == false)
            {
                Magician.AppearConsole();
                DeleteMenu(GetSystemMenu(GetConsoleWindow(), false), SC_CLOSE, MF_BYCOMMAND);
                showConsoleToolStripMenuItem.Checked = true;
            }
                else 
            {
                showConsoleToolStripMenuItem.Checked = false;
                Magician.DisappearConsole();
            }
        }

        private void ImportEXCL_Click(object sender, EventArgs e)
        {

            dataViewer.DataSource = null;
            DataTable DT = (DataTable)dataViewer.DataSource;
            if (DT != null)
                DT.Clear();

            dataViewer.Rows.Clear();
            dataViewer.Refresh();
            int count = this.dataViewer.Columns.Count;
            for (int i = 0; i < count; i++)
                this.dataViewer.Columns.RemoveAt(0);


            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "�������� �������� Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string xlFileName = ofd.FileName;
            ExlFileName = Path.GetFileName(xlFileName);

            Console.WriteLine("Open new Excel file: " + Path.GetFileName(xlFileName));

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWB;
            Excel.Worksheet xlSht;
            xlWB = xlApp.Workbooks.Add(xlFileName);         
            xlSht = xlWB.Worksheets[1];

            Excel.Range ExcelRange = xlSht.UsedRange;
            Excel.Range rng = xlSht.Cells[11, ExcelRange.Columns.Count + 1];
            rng = rng.Columns.End[Excel.XlDirection.xlToLeft];
            long lastCol = rng.Column;
            long FirstUsedRow = 1;

            for (int i = 1; i<=10; i++)
            {
                if (xlSht.Cells[i,1].Value != null)
                {
                    FirstUsedRow = i;
                    break;
                }
            }

            String SheetName = xlSht.Name;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + xlFileName + ";Extended Properties='Excel 12.0;HDR=NO;IMEX=1;'");
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + SheetName + "$]", con);
            con.Open();
            DataTable data = new DataTable();
            sda.Fill(data);

            dataViewer.DataSource = data;
            dataViewer.AllowUserToAddRows = false;
            dataViewer.AllowUserToDeleteRows = false;

            int ick = 0;

            for (int i=0; i<(data.Rows.Count); i++)
            {
                if (dataViewer.Rows[i].Cells[data.Columns.Count-1].Value == DBNull.Value)
                {
                    ick++;
                }
            }

            Console.WriteLine("Empty cells: " + ick.ToString());
            Console.WriteLine("Rows.Count: " + dataViewer.Rows.Count.ToString());
            Console.WriteLine("Columns.Count: " + dataViewer.Columns.Count.ToString());

            int colCount = data.Columns.Count;

            if (ick == data.Rows.Count)
            {
                colCount = data.Columns.Count - 1;
                dataViewer.Columns.RemoveAt(colCount);
                Console.WriteLine("Deleted last Column");
            }

            //DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            //dataViewer.Columns.Insert(0, checkBoxColumn);

            Point headerCellLocation = dataViewer.GetCellDisplayRectangle(-1, -1, true).Location;

            foreach (DataGridViewColumn column in dataViewer.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                column.Width = 120;
            }

            foreach (DataGridViewRow row in dataViewer.Rows)
            {
                {
                    row.HeaderCell.Value = "ROW " + FirstUsedRow.ToString();
                    FirstUsedRow++;
                }
            }

            //dataViewer.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dataViewer.EnableHeadersVisualStyles = false;

            //dataViewer.CellContentClick += new DataGridViewCellEventHandler(DataViewer_SwitchCheckRow);
            //dataViewer.CellContentClick += new DataGridViewCellEventHandler(DataViewer_CheckClick);
            dataViewer.MouseDown += new MouseEventHandler(dataViewer_MouseClick);
            dataViewer.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(DataViewer_RowSelected);
            dataViewer.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(DataViewer_ColumnsSelected);

            RowsCnt = dataViewer.RowCount;

            FillStatusGrid(RowsCnt, colCount);
            statusGridView.Rows[1].Cells[1].Value = colCount;
            statusGridView.Rows[4].Cells[1].Value = 0;

            for (int i = 0; i < FormName.Items.Count; i++)
            {
                int c = FormName.Items[i].ToString().IndexOf(Path.GetFileNameWithoutExtension(xlFileName).Substring(Path.GetFileNameWithoutExtension(xlFileName).LastIndexOf("_") + 1));
                if (c >= 0)
                {
                    FormName.Text = "presset_" + FormName.Items[i].ToString();
                    statusGridView.Rows[0].Cells[1].Value = FormName.Text;
                }
            }

            tempPropVal.Add(PropGrid.cntHeadsRows); //[0] - Rows counts take Header
            optionsGrid.Refresh();

            xlWB.Close(false, false, false);
            xlApp.Quit();
            xlApp = null;
            xlWB = null;
            xlSht = null;
            GC.Collect();
        }

        private void FillStatusGrid(int maxRows, int maxCols)
        {
            statusGridView.Rows.Add();
            statusGridView.Rows[0].HeaderCell.Value = "PressetName";
            statusGridView.Rows[0].Cells[0].Value = "PressetName";

            statusGridView.Rows.Add();
            statusGridView.Rows[1].HeaderCell.Value = "ColumnsCounts";
            statusGridView.Rows[1].Cells[0].Value = "ColumnsCounts";
            statusGridView.Rows[1].Cells[1] = new NumericUpDownDataGrid.NumericUpDownCell(0, 999);

            statusGridView.Rows.Add();
            statusGridView.Rows[2].HeaderCell.Value = "FirstHeaderRow";
            statusGridView.Rows[2].Cells[0].Value = "FirstHeaderRow";
            statusGridView.Rows[2].Cells[1] = new NumericUpDownDataGrid.NumericUpDownCell(0, (maxRows-PropGrid.cntHeadsRows)+1);

            statusGridView.Rows.Add();
            statusGridView.Rows[3].HeaderCell.Value = "FirstDataRow";
            statusGridView.Rows[3].Cells[0].Value = "FirstDataRow";
            statusGridView.Rows[3].Cells[1] = new NumericUpDownDataGrid.NumericUpDownCell(0, maxRows);

            statusGridView.Rows.Add();
            statusGridView.Rows[4].HeaderCell.Value = "Steps";
            statusGridView.Rows[4].Cells[0].Value = "Steps";
            statusGridView.Rows[4].Cells[1] = new NumericUpDownDataGrid.NumericUpDownCell(0, 10);

            statusGridView.Rows.Add();
            statusGridView.Rows[5].HeaderCell.Value = "ExportColumns";
            statusGridView.Rows[5].Cells[0].Value = "ExportColumns";

            statusGridView.Rows.Add();
            statusGridView.Rows[6].HeaderCell.Value = "ColumnsChecks";
            statusGridView.Rows[6].Cells[0].Value = "ColumnsChecks";

            statusGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            statusGridView.CellEndEdit += statusGridView_CellEndEdit;
            statusGridView.MouseDown += new MouseEventHandler(statusGridView_MouseClick);

            statusGridView.ClearSelection();
            TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["DRow"].SetReadOnlyAttribute(false);
            TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["cntHeadsRows"].SetReadOnlyAttribute(false);
        }

        private void SettingsNewForm()
        {
            TreeView.Name = "Form3";
            TreeView.Text = "Extracted columns";
            TreeView.WindowState = FormWindowState.Normal;
            TreeView.FormBorderStyle = FormBorderStyle.FixedSingle;
            TreeView.MaximizeBox = false;

            TreeColViewer.Location = new Point(5, 40);
            TreeColViewer.ColumnHeadersVisible = true;
            TreeColViewer.RowHeadersVisible = true;
            TreeColViewer.ScrollBars = ScrollBars.None;
            TreeColViewer.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9);
            TreeColViewer.RowTemplate.MinimumHeight = 18;
            TreeColViewer.RowTemplate.Height = 18;

            TreeColViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            TreeColViewer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            TreeColViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TreeColViewer.EditMode = DataGridViewEditMode.EditOnEnter;
            TreeColViewer.RowHeadersWidth = 70;
            TreeView.Controls.Add(TreeColViewer);

            TextExtractColumns.Location = new Point(5, 10);
            TreeView.Controls.Add(TextExtractColumns);

            ConfirmCols.Text = "Confirm";
            ConfirmCols.Size = new Size(120, 30);
            ConfirmCols.Enabled = false;
        }

        private void LoadListName()
        {
            string[] ListName = { "buy_norem", "cfrliab", "cfrliabdpg", "CESSM", "CFR_PART_LIAB_DEL_NOTICE", "svnc_part_s_plan", "PROGN_LIAB_FRSFG", "power_consumer_3_fact", "frs_dev_factcost" };
            FormName.Items.AddRange(ListName);
        }

        private void StripMenuHeaderRow_Click(object sender, EventArgs e)
        {
            TreeFormDestroyer();

            foreach (DataGridViewRow rws in dataViewer.Rows)
            {
                if (rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads | rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads)
                {
                    rws.DefaultCellStyle.BackColor = Color.Empty;
                    rws.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (ActiveCell.RowIndex >= 0 && ActiveCell.ColumnIndex == 0 && ActiveCell.RowIndex+ Convert.ToInt32(PropGrid.cntHeadsRows) <= RowsCnt)
            {
                HFR = ActiveCell.RowIndex + 1;
                statusGridView.Rows[2].Cells[1].Value = Convert.ToInt32(dataViewer.Rows[ActiveCell.RowIndex].HeaderCell.Value.ToString().Split(' ').Last());
                dataViewer.Rows[ActiveCell.RowIndex].DefaultCellStyle.BackColor = PropGrid.ColorHeads;
                dataViewer.Rows[ActiveCell.RowIndex].DefaultCellStyle.ForeColor = fntCl;

                if (PropGrid.DRow == true)
                {
                    for (int i = 1; i < Convert.ToInt32(PropGrid.cntHeadsRows); i++)
                    {
                        dataViewer.Rows[ActiveCell.RowIndex + i].DefaultCellStyle.BackColor = PropGrid.ColorHeads;
                        dataViewer.Rows[ActiveCell.RowIndex+i].DefaultCellStyle.ForeColor = fntCl;
                    }
                }
            }
            tempPropVal.Add(Convert.ToInt32(statusGridView.Rows[2].Cells[1].Value)); //[1] - Rows counts take Header
            dataViewer.ClearSelection();
            statusGridView.ClearSelection();
            optionsGrid.Refresh();
        }

        private void StripMenuFirstData_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataViewer.Rows)
            {
                if (row.DefaultCellStyle.BackColor == PropGrid.ColorDataRows | row.DefaultCellStyle.BackColor == PropGrid.ColorDataRows)
                {
                    row.DefaultCellStyle.BackColor = Color.Empty;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }

            if (ActiveCell != null && ActiveCell.RowIndex <= RowsCnt)
            {
                statusGridView.Rows[3].Cells[1].Value = Convert.ToInt32(dataViewer.Rows[(ActiveCell.RowIndex)].HeaderCell.Value.ToString().Split(' ').Last());
                dataViewer.Rows[(ActiveCell.RowIndex)].DefaultCellStyle.BackColor = PropGrid.ColorDataRows;
                dataViewer.Rows[(ActiveCell.RowIndex)].DefaultCellStyle.ForeColor = fntClDat;

                for (int i = (ActiveCell.RowIndex + Convert.ToInt32(statusGridView.Rows[4].Cells[1].Value) + 1); i < RowsCnt; i += Convert.ToInt32(statusGridView.Rows[4].Cells[1].Value) + 1)
                {
                    if (dataViewer.Rows[i].Cells[1].Value != DBNull.Value)
                    {
                        dataViewer.Rows[i].DefaultCellStyle.BackColor = PropGrid.ColorDataRows;
                        dataViewer.Rows[i].DefaultCellStyle.ForeColor = fntClDat;
                    }
                }
                dataViewer.ClearSelection();
                optionsGrid.Refresh();
            }
        }

        private void import2Universal_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "\\";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Multiselect = false;
            ofd.DefaultExt = "*.xml";
            ofd.Filter = "XML data (*.xml*)|*.xml*";
            ofd.Title = "Open XML file";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            xmlFileName = ofd.FileName;

            XMLParser();
        }

        private void FileWriter(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Multiselect = false;
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Microsoft Excel (*.xls*)|*.xls*";
            ofd.Title = "�������� �������� Excel";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string xlFileName = ofd.FileName;

            //string xlFileName = "C:\\Users\\ChernyshovKS\\Desktop\\temp_tester\\20220828_TULAENSK_cfrliabdpg.xls";

            for (int i = 0; i < FormName.Items.Count; i++)
            {
                int c = FormName.Items[i].ToString().IndexOf(Path.GetFileNameWithoutExtension(xlFileName).Substring(Path.GetFileNameWithoutExtension(xlFileName).LastIndexOf("_")+1));

                if (c >= 0)
                {
                    string LastChars = "\\presset_" + FormName.Items[i].ToString() + ".xml";
                    xmlFileName = Environment.CurrentDirectory + LastChars;
                    Console.WriteLine("Selected presset: " + LastChars);
                    Console.WriteLine("File.Exists: " + xmlFileName.ToString());
                }
            }



            if (File.Exists(xmlFileName))
            {
                XMLParser();

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWB;
                Excel.Worksheet xlSht;
                xlWB = xlApp.Workbooks.Add(xlFileName);
                xlSht = xlWB.Worksheets[1];

                int we = dt_db_shema.Rows.Count;
                int ww = 0;


                for (int i = 0; i < obj1.Length + Convert.ToInt32(extraColumns.Value); i++)
                {
                    dt_db_shema.Columns.Add();
                }


                for (int i = Convert.ToInt32(firstData.Value); xlSht.Cells[i, 1].Text != string.Empty || xlSht.Cells[i, 4].Text != string.Empty || xlSht.Cells[i, 2].Text != string.Empty; i++)
                {

                    if (xlSht.Cells[i, 1].Text != string.Empty && xlSht.Cells[i, 4].Text != string.Empty)
                    {
                        ww++;
                        dt_db_shema.Rows.Add();
                        for (int j = 0; j <= Convert.ToInt32(extraColumns.Value); j++)
                        {
                            dt_db_shema.Rows[we][j] = xlSht.Cells[4, 3].Value;
                        }
                        for (int c = 0; c < obj1.Length; c++)
                        {
                            if (xlSht.Cells[i, obj1[c]].Text != string.Empty)
                            {
                                dt_db_shema.Rows[we][c + Convert.ToInt32(extraColumns.Value)] = xlSht.Cells[i, obj1[c]].Value;
                            }
                            else
                            {
                                dt_db_shema.Rows[we][c + Convert.ToInt32(extraColumns.Value)] = 0;
                            }
                        }
                        we++;
                    }
                }

                dataViewer.DataSource = null;
                DataTable DT = (DataTable)dataViewer.DataSource;
                if (DT != null)
                    DT.Clear();

                dataViewer.Rows.Clear();
                dataViewer.Refresh();
                int count = this.dataViewer.Columns.Count;
                for (int i = 0; i < count; i++)
                    this.dataViewer.Columns.RemoveAt(0);


                foreach (DataGridViewColumn column in dataViewer.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                dataViewer.DataSource = dt_db_shema;
                dataViewer.AllowUserToAddRows = false;
                dataViewer.AllowUserToDeleteRows = false;
                dataViewer.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

                xlWB.Close(false, false, false);
                xlApp.Quit();
                xlApp = null;
                xlWB = null;
                xlSht = null;
                GC.Collect();
            }
            else
            {
                Console.WriteLine("XML file not found, be sure that the folder contains the necessary files.");
            }

        }

        private void XMLParser()
        {

            Console.WriteLine("Starting XML parsing...");

                XDocument XMLfile = XDocument.Load(xmlFileName);

                    DataSet ds = new DataSet();

                    int n = 0;
                    ds.ReadXml(xmlFileName);

                    foreach (XElement infoElement in XMLfile.Root.Elements("usedColumns"))
                    {
                        strID = infoElement.Element("id");
                        Array.Resize(ref obj1, n + 1);
                        obj1[n] = Convert.ToInt32(strID.Value);
                        Console.WriteLine(obj1[n].ToString() + "; ");
                        n++;
                    }

                    foreach (XElement infoElement in XMLfile.Root.Elements("commonSettings"))
                    {
                        extraColumns = infoElement.Element("extraColumns");
                        headsRow = infoElement.Element("headsRow");
                        firstData = infoElement.Element("firstData");
                        columnsCount = infoElement.Element("columnsCount");
                        Console.WriteLine("extraColumns: " + extraColumns.Value + "; headsRow: " + headsRow.Value + "; firstData: " + firstData.Value + "; columnsCount: " + columnsCount.Value + "; ");
                    }
                    return;
        }

        private void TreeFormDestroyer()
        {
            cntShows = 0;
            
            TreeColViewer.Columns.Clear();
            TreeColViewer.Rows.Clear();
            TextExtractColumns.Text = "";
            allowVoid = false;
        }

        private void ColsChecker()
        {
            string clck = statusGridView.Rows[6].Cells[1].Value.ToString();
            string[] spclck = clck.Split(';');
            foreach(string sp in spclck)
            Console.WriteLine(sp + " | ");
        }

        private void propGrid_stripHelp(object sender, EventArgs e)
        {
                optionsGrid.HelpVisible = !optionsGrid.HelpVisible;
                helpToolStripMenuItem.Checked = !helpToolStripMenuItem.Checked;
        }

        private void optionsGrid_PropertyValueChanged(Object sender, PropertyValueChangedEventArgs e)
        {

            if (PropGrid.useExtraCol == true)
            {
                TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["ExtraColCnt"].SetReadOnlyAttribute(false);
            }
            
            if (PropGrid.useExtraCol == false)
            {
                TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["ExtraColCnt"].SetReadOnlyAttribute(true);
                PropGrid.ExtraColCnt = 0;
            }

            if (PropGrid.DRow == true && PropGrid.cntHeadsRows < 2)
            {
                TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["cntHeadsRows"].SetReadOnlyAttribute(false);
                PropGrid.cntHeadsRows = 2;
            }

            if (PropGrid.DRow == false)
            {
                TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["cntHeadsRows"].SetReadOnlyAttribute(true);
                PropGrid.cntHeadsRows = 1;
            }

            if (PropGrid.ExtraColCnt > 10)
                PropGrid.ExtraColCnt = 10;

            

            if (PropGrid.cntHeadsRows != prvCntHedRw)
            {
                prvCntHedRw = PropGrid.cntHeadsRows;
                TreeFormDestroyer();
            }

            AutoFillList();
            autoFontColor();
            ConfigUpdater();
            updateDataGridColors();

            if (dataViewer.DataSource != null)
            {
                if (PropGrid.cntHeadsRows > RowsCnt)
                { PropGrid.cntHeadsRows = RowsCnt; }
                updateStatusGrid(PropGrid.cntHeadsRows);
            }
                
        }

        private void updateDataGridColors()
        {
            foreach (DataGridViewRow row in dataViewer.Rows)
            {
                if (row.DefaultCellStyle.BackColor == Color.FromName(tempPropColors[0].Name))
                {
                    row.DefaultCellStyle.BackColor = PropGrid.ColorHeads;
                    row.DefaultCellStyle.ForeColor = fntCl;
                }
                if (row.DefaultCellStyle.BackColor == Color.FromName(tempPropColors[1].Name))
                {
                    row.DefaultCellStyle.BackColor = PropGrid.ColorDataRows;
                    row.DefaultCellStyle.ForeColor = fntClDat;
                }
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.FromName(tempPropColors[2].Name))
                    {
                        cell.Style.BackColor = PropGrid.ColorStaticDat;
                        cell.Style.ForeColor = fntClStaticDat;
                    }
                }
            }
            tempPropColors[0] = PropGrid.ColorHeads;
            tempPropColors[1] = PropGrid.ColorDataRows;
            tempPropColors[2] = PropGrid.ColorStaticDat;
            tempPropColors[3] = PropGrid.SecondColorHeads;
        }

        private void updateStatusGrid(int lastVal)
        {
            if (tempPropVal[0] != lastVal && TypeDescriptor.GetProperties(this.optionsGrid.SelectedObject)["cntHeadsRows"].IsReadOnly == false)
            {
                statusGridView.Rows[2].Cells[1].Value = null;
                statusGridView.Rows[2].Cells[1] = new NumericUpDownDataGrid.NumericUpDownCell(0, (RowsCnt - PropGrid.cntHeadsRows) + 1);

                foreach (DataGridViewRow rws in dataViewer.Rows)
                {
                    if (rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads | rws.DefaultCellStyle.BackColor == PropGrid.ColorHeads)
                    {
                        rws.DefaultCellStyle.BackColor = Color.Empty;
                        rws.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
                tempPropVal[0] = lastVal;
                TreeFormDestroyer();
            }
        }

        private void autoFontColor()
        {
            if (PropGrid.ColorHeads.R < 120 | PropGrid.ColorHeads.G < 120 | PropGrid.ColorHeads.B < 120)
                fntCl = Color.White;
            else
                fntCl = Color.Black;

            if (PropGrid.ColorDataRows.R < 120 | PropGrid.ColorDataRows.G < 120 | PropGrid.ColorDataRows.B < 120)
                fntClDat = Color.White;
            else
                fntClDat = Color.Black;

            if (PropGrid.SecondColorHeads.R < 100 | PropGrid.SecondColorHeads.G < 100 | PropGrid.SecondColorHeads.B < 120)
                fntTreeCl = Color.White;
            else
                fntTreeCl = Color.Black;

            if (PropGrid.ColorStaticDat.R < 100 | PropGrid.ColorStaticDat.G < 100 | PropGrid.ColorStaticDat.B < 120)
                fntClStaticDat = Color.White;
            else
                fntClStaticDat = Color.Black;
        }

        private void CheckRegLib()
        {
            RegistryKey root = Registry.ClassesRoot;
            RegistryKey TypeLib = root.OpenSubKey("TypeLib");

            RegistryKey OleDB = TypeLib.OpenSubKey("{00020813-0000-0000-C000-000000000046}");
            try
            {
                //Console.WriteLine("Cheked sub: {0}.", OleDB.Name + " check status � ok.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());

                Console.WriteLine("Sub with ID {00020813-0000-0000-C000-000000000046} not registred, check status � failed.");
            }

            RegistryKey lastKey = OleDB.OpenSubKey("1.9");
            try
            {
                Console.WriteLine("Cheked sub: {0}.", lastKey.Name + " check status � ok.");

                lastKey.Close();
                OleDB.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.GetType());

                Console.WriteLine("Lib ver.1.9 not registred, check status � failed.");
                OleDB.Close();
            }
            TypeLib.Close();
            root.Close();
        }

        private void RigesterCOMfix(object sender, EventArgs e)
        {
            RegistryKey root = Registry.ClassesRoot;
            RegistryKey TypeLib = root.OpenSubKey("TypeLib", true);

            RegistryKey OleDB = TypeLib.OpenSubKey("{00020813-0000-0000-C000-000000000046}", true);
            try
            {
                Console.WriteLine("Open sub: {0}.", OleDB.Name);
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                Console.WriteLine(d.GetType());

                TypeLib.CreateSubKey("{00020813-0000-0000-C000-000000000046}");
                OleDB = TypeLib.OpenSubKey("{00020813-0000-0000-C000-000000000046}", true);

                Console.WriteLine("SubKey: " + OleDB.Name + " was created.");
            }

            RegistryKey lastKey = OleDB.OpenSubKey("1.9", true);
            try
            {
                Console.WriteLine("Open sub: {0}.", lastKey.Name);
                lastKey.Close();
                OleDB.Close();
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                Console.WriteLine(d.GetType());

                OleDB = TypeLib.OpenSubKey("{00020813-0000-0000-C000-000000000046}", true);
                OleDB.CreateSubKey("1.9");
                lastKey = OleDB.OpenSubKey("1.9", true);
                lastKey.SetValue(default, "Microsoft Excel 16.0 Object Library");
                lastKey.SetValue("PrimaryInteropAssemblyName", "Microsoft.Office.Interop.Excel, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71E9BCE111E9429C");


                Console.WriteLine("SubKey: " + lastKey.Name + " was created.");

                lastKey.Close();
                OleDB.Close();
            }
            TypeLib.Close();
            root.Close();
        }

        class Magician
        {
            [DllImport("kernel32.dll")]
            static extern IntPtr GetConsoleWindow();

            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            const int HIDE = 0;
            const int SHOW = 5;

            public static void DisappearConsole()
            {
                ShowWindow(GetConsoleWindow(), HIDE);
            }

            public static void AppearConsole()
            {
                ShowWindow(GetConsoleWindow(), SHOW);
            }
        }
    }
}