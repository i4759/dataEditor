﻿using dataEditor.Properties;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing.Design;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using NPOI.OpenXmlFormats.Wordprocessing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Runtime.Serialization;
using System.Xml;
using static System.ComponentModel.TypeConverter;
using static NPOI.SS.Formula.PTG.ArrayPtg;
using dataEditor.data.forms;

namespace dataEditor.data
{
    class commonSettings
    {
        private string m_ImportMode;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Available import methods")]
        [DisplayName("ImportMode")]
        [Category("ImportSettings")]
        [TypeConverter(typeof(ImportMode))]
        public string ImportMode
        {
            get { return m_ImportMode; }
            set { m_ImportMode = value; }
        }

        private bool m_showListExcelSheets = true;
        [Browsable(true)]
        [Description("Выводить диалоговое окно для выбора извлекаемого из Excel листа")]
        [DisplayName("ShowAvailableExcelSheets")]
        [Category("ImportSettings")]
        public bool showListExcelSheets
        {
            get { return m_showListExcelSheets; }
            set { m_showListExcelSheets = value; }
        }

        public EmptyRowsCheckSettings m_CheckEmptyRows = new EmptyRowsCheckSettings(true, 10, 10);
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Check the real range to exclude empty cells")]
        [DisplayName("СheckRealRange")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("ImportSettings")]
        public EmptyRowsCheckSettings CheckEmptyRows
        {
            get { return m_CheckEmptyRows; }
            set { m_CheckEmptyRows = value; }
        }

        public OleDBModeSets m_OleDBImportMode = new OleDBModeSets("", false, 1);
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Alternative method imports using provider Microsoft Access for fill dataGrid and available only with installed and registered Microsoft.ACE.OLEDB.12.0")]
        [DisplayName("OLEDBprovider")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [Category("ImportSettings")]
        public OleDBModeSets OleDBImportMode
        {
            get { return m_OleDBImportMode; }
            set { m_OleDBImportMode = value; }
        }

        private string m_StartPage;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Select default page")]
        [DisplayName("StartPage")]
        [Category("App")]
        [TypeConverter(typeof(StartPage))]
        public string StartPage
        {
            get { return m_StartPage; }
            set { m_StartPage = value; }
        }

        private string m_GlobalInfoStandart;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("LocalStandart")]
        [Category("App")]
        [TypeConverter(typeof(GlobalStandarts))]
        public string GlobalInfoStandart
        {
            get { return m_GlobalInfoStandart; }
            set { m_GlobalInfoStandart = value; }
        }

        private bool m_ForceCloseExl;
        [Browsable(true)]
        [Description("Terminate all Excel processes before closing the program")]
        [DisplayName("ForceCloseAllExcel")]
        [Category("App")]
        public bool ForceCloseExl
        {
            get { return m_ForceCloseExl; }
            set { m_ForceCloseExl = value; }
        }

        private bool m_ShowConsoleOnStartUp = false;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Open console whith starts programm")]
        [DisplayName("ShowConsoleOnStartUp")]
        [Category("App")]
        public bool ShowConsoleOnStartUp
        {
            get { return m_ShowConsoleOnStartUp; }
            set { m_ShowConsoleOnStartUp = value; }
        }

        private bool m_ShowHelpPropetryGrid = false;
        [Browsable(false)]
        [ReadOnly(false)]
        [Description("Show help area in property grid")]
        [DisplayName("ShowHelpPropetryGrid")]
        [Category("App")]
        public bool ShowHelpPropetryGrid
        {
            get { return m_ShowHelpPropetryGrid; }
            set { m_ShowHelpPropetryGrid = value; }
        }
    }

    class ExcelReaderSettings
    {
        string[] m_sqlArray = { };
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Used SQL collumns")]
        [DisplayName("SQLcollumns")]
        [Category("SQL")]
        [TypeConverter(typeof(CollectionTypeConverter))]
        public string[] sqlArray { get { return m_sqlArray; } set { m_sqlArray = value; } }

        Color m_ColorHeads = Color.Gray;
        [Browsable(true)]
        [Description("Color for choosing rows contains Headers")]
        [DisplayName("ColorHeaders")]
        [Category("Visuals")]

        public Color ColorHeads
        {
            get { return m_ColorHeads; }
            set { m_ColorHeads = value; }
        }

        Color m_SecondColorHeads = Color.PaleGreen;
        [Browsable(true)]
        [Description("Color for next rows in Header")]
        [DisplayName("ColorHeaders(ListView)")]
        [Category("Visuals")]

        public Color SecondColorHeads
        {
            get { return m_SecondColorHeads; }
            set { m_SecondColorHeads = value; }
        }

        Color m_ColorDataRows = Color.Silver;
        [Browsable(true)]
        [Description("Color for rows contains data")]
        [DisplayName("ColorDataRows")]
        [Category("Visuals")]

        public Color ColorDataRows
        {
            get { return m_ColorDataRows; }
            set { m_ColorDataRows = value; }
        }

        Color m_ColorStaticDat = Color.Violet;
        [Browsable(true)]
        [Description("Color selected cells using for static values")]
        [DisplayName("ColorStaticCell")]
        [Category("Visuals")]

        public Color ColorStaticDat
        {
            get { return m_ColorStaticDat; }
            set { m_ColorStaticDat = value; }
        }
    }

    class MicrogenerationSettings
    {
        public mgRegions m_mgCodeName = new mgRegions("", "");
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Available regions for microgenerations.")]
        [DisplayName("GTP")]
        [Category("Microgeneration")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public mgRegions mgCodeName
        {
            get { return m_mgCodeName; }
            set { m_mgCodeName = value; }
        }

        private DateTime m_rDateSVNC = Convert.ToDateTime(10 + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Число месяца публикации СВНЦ на сайте АТС")]
        [DisplayName("ReleaseSVNC")]
        [Category("Microgeneration")]
        public DateTime rDateSVNC
        {
            get { return m_rDateSVNC; }
            set { m_rDateSVNC = value; }
        }

        private bool m_deleteDownloadsFiles = true;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Delete downloaded file")]
        [DisplayName("DeleteDownloadedFile")]
        [Category("Microgeneration")]
        public bool deleteDownloadsFiles
        {
            get { return m_deleteDownloadsFiles; }
            set { m_deleteDownloadsFiles = value; }
        }


        mgFolderProject m_mgFolderProject = new mgFolderProject();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Показать папку с проектом в проводнике")]
        [DisplayName("Project")]
        [Category("Folders")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public mgFolderProject mgFolderProject
        {
            get { return m_mgFolderProject; }
            set { m_mgFolderProject = value; }
        }

        mgFolderAgreeDictionary m_mgFolderAgreeDict = new mgFolderAgreeDictionary();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Показать папку с проектом в проводнике")]
        [DisplayName("AgreementDictionary")]
        [Category("Folders")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public mgFolderAgreeDictionary mgFolderAgreeDict
        {
            get { return m_mgFolderAgreeDict; }
            set { m_mgFolderAgreeDict = value; }
        }

        mgFolderBanksDictionary m_mgFolderBanksDict = new mgFolderBanksDictionary();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Показать папку с проектом в проводнике")]
        [DisplayName("BanksDictionary")]
        [Category("Folders")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public mgFolderBanksDictionary mgFolderBanksDict
        {
            get { return m_mgFolderBanksDict; }
            set { m_mgFolderBanksDict = value; }
        }

        mgFolderDownloads m_mgFolderDonwloads = new mgFolderDownloads();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Показать папку с проектом в проводнике")]
        [DisplayName("Donwloads")]
        [Category("Folders")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public mgFolderDownloads mgFolderDonwloads
        {
            get { return m_mgFolderDonwloads; }
            set { m_mgFolderDonwloads = value; }
        }

        private string m_siteLinkSPUNC;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Ссылка на сайт энергосбыта, где публикуются средневзвешенные нерегулируемые цены на электроэнергию")]
        [DisplayName("defaultLinkSite")]
        [Category("Microgeneration")]
        public string defaultSiteLink
        {
            get { return m_siteLinkSPUNC; }
            set { m_siteLinkSPUNC = value; }
        }

        hoursTariffZone m_mgHoursZone = new hoursTariffZone();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("HoursZone")]
        [Category("HoursSettings")]
        [Editor(typeof(ZoneEditor), typeof(UITypeEditor))]
        //[TypeConverter(typeof(ExpandableObjectConverter))]
        public hoursTariffZone mgHoursZone
        {
            get { return m_mgHoursZone; }
            set { m_mgHoursZone = value; }
        }


        companyDataEditor m_mgCompany = new companyDataEditor();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("CompanyData")]
        [Category("CompanySettings")]
        [Editor(typeof(CompanyEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public companyDataEditor mgCompany
        {
            get { return m_mgCompany; }
            set { m_mgCompany = value; }
        }

        signedDataEditor m_mgSigned = new signedDataEditor();
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("Signed")]
        [Category("SignSettings")]
        [Editor(typeof(SignedEditor), typeof(UITypeEditor))]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public signedDataEditor mgSigned
        {
            get { return m_mgSigned; }
            set { m_mgSigned = value; }
        }

    }

    class urProperty
    {
        private bool m_DRow = true;
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Headers takes over 2 rows in table")]
        [DisplayName("MultiRowHeaders")]
        [Category("Explore Mode")]
        public bool DRow
        {
            get { return m_DRow; }
            set { m_DRow = value; }
        }

        private int m_cntHeadsRows = 2;
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Count of rows takes header")]
        [DisplayName("CountHeadresRow")]
        [Category("Explore Mode")]
        public int cntHeadsRows
        {
            get { return m_cntHeadsRows; }
            set { m_cntHeadsRows = value; }
        }


        private bool m_useExtraCol = false;
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Enable extra columns")]
        [DisplayName("UseExtraColumns")]
        [Category("Extra Columns")]
        public bool useExtraCol
        {
            get { return m_useExtraCol; }
            set { m_useExtraCol = value; }
        }

        private int m_ExtraColCnt;
        [Browsable(true)]
        [Description("Count extra columns")]
        [DisplayName("CountExtraColumns")]
        [Category("Extra Columns")]
        public int ExtraColCnt
        {
            get { return m_ExtraColCnt; }
            set { m_ExtraColCnt = value; }
        }
    }

    public class CustomFolderNameEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            CustomFolderBrowser browser = new CustomFolderBrowser();

            if (value != null)
            {
                browser.DirectoryPath = string.Format("{0}", value);
            }

            if (browser.ShowDialog(null) == DialogResult.OK)
            {
                return browser.DirectoryPath;
            }
            return value;
        }
    }


    public class CustomFolderBrowser
    {
        public string DirectoryPath { get; set; }

        public DialogResult ShowDialog(IWin32Window owner)
        {
            IntPtr hwndOwner = owner != null ? owner.Handle : GetActiveWindow();

            IFileOpenDialog dialog = (IFileOpenDialog)new FileOpenDialog();
            try
            {
                IShellItem item;
                if (!string.IsNullOrEmpty(DirectoryPath))
                {
                    IntPtr idl;
                    uint atts = 0;
                    if (SHILCreateFromPath(DirectoryPath, out idl, ref atts) == 0)
                    {
                        if (SHCreateShellItem(IntPtr.Zero, IntPtr.Zero, idl, out item) == 0)
                        {
                            dialog.SetFolder(item);
                        }
                        Marshal.FreeCoTaskMem(idl);
                    }
                }
                dialog.SetOptions(FOS.FOS_PICKFOLDERS | FOS.FOS_FORCEFILESYSTEM);
                uint hr = dialog.Show(hwndOwner);
                if (hr == ERROR_CANCELLED)
                    return DialogResult.Cancel;

                if (hr != 0)
                    return DialogResult.Abort;

                dialog.GetResult(out item);
                string path;
                item.GetDisplayName(SIGDN.SIGDN_FILESYSPATH, out path);
                DirectoryPath = path;
                return DialogResult.OK;
            }
            finally
            {
                Marshal.ReleaseComObject(dialog);
            }
        }

        [DllImport("shell32.dll")]
        private static extern int SHILCreateFromPath([MarshalAs(UnmanagedType.LPWStr)] string pszPath, out IntPtr ppIdl, ref uint rgflnOut);

        [DllImport("shell32.dll")]
        private static extern int SHCreateShellItem(IntPtr pidlParent, IntPtr psfParent, IntPtr pidl, out IShellItem ppsi);

        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();

        private const uint ERROR_CANCELLED = 0x800704C7;

        [ComImport]
        [Guid("DC1C5A9C-E88A-4dde-A5A1-60F82A20AEF7")]
        private class FileOpenDialog
        {
        }

        [ComImport]
        [Guid("42f85136-db7e-439c-85f1-e4075d135fc8")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IFileOpenDialog
        {
            [PreserveSig]
            uint Show([In] IntPtr parent); // IModalWindow
            void SetFileTypes();  // not fully defined
            void SetFileTypeIndex([In] uint iFileType);
            void GetFileTypeIndex(out uint piFileType);
            void Advise(); // not fully defined
            void Unadvise();
            void SetOptions([In] FOS fos);
            void GetOptions(out FOS pfos);
            void SetDefaultFolder(IShellItem psi);
            void SetFolder(IShellItem psi);
            void GetFolder(out IShellItem ppsi);
            void GetCurrentSelection(out IShellItem ppsi);
            void SetFileName([In, MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetFileName([MarshalAs(UnmanagedType.LPWStr)] out string pszName);
            void SetTitle([In, MarshalAs(UnmanagedType.LPWStr)] string pszTitle);
            void SetOkButtonLabel([In, MarshalAs(UnmanagedType.LPWStr)] string pszText);
            void SetFileNameLabel([In, MarshalAs(UnmanagedType.LPWStr)] string pszLabel);
            void GetResult(out IShellItem ppsi);
            void AddPlace(IShellItem psi, int alignment);
            void SetDefaultExtension([In, MarshalAs(UnmanagedType.LPWStr)] string pszDefaultExtension);
            void Close(int hr);
            void SetClientGuid();  // not fully defined
            void ClearClientData();
            void SetFilter([MarshalAs(UnmanagedType.Interface)] IntPtr pFilter);
            void GetResults([MarshalAs(UnmanagedType.Interface)] out IntPtr ppenum); // not fully defined
            void GetSelectedItems([MarshalAs(UnmanagedType.Interface)] out IntPtr ppsai); // not fully defined
        }

        [ComImport]
        [Guid("43826D1E-E718-42EE-BC55-A1E261C37BFE")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IShellItem
        {
            void BindToHandler(); // not fully defined
            void GetParent(); // not fully defined
            void GetDisplayName([In] SIGDN sigdnName, [MarshalAs(UnmanagedType.LPWStr)] out string ppszName);
            void GetAttributes();  // not fully defined
            void Compare();  // not fully defined
        }

        private enum SIGDN : uint
        {
            SIGDN_DESKTOPABSOLUTEEDITING = 0x8004c000,
            SIGDN_DESKTOPABSOLUTEPARSING = 0x80028000,
            SIGDN_FILESYSPATH = 0x80058000,
            SIGDN_NORMALDISPLAY = 0,
            SIGDN_PARENTRELATIVE = 0x80080001,
            SIGDN_PARENTRELATIVEEDITING = 0x80031001,
            SIGDN_PARENTRELATIVEFORADDRESSBAR = 0x8007c001,
            SIGDN_PARENTRELATIVEPARSING = 0x80018001,
            SIGDN_URL = 0x80068000
        }

        [Flags]
        private enum FOS
        {
            FOS_ALLNONSTORAGEITEMS = 0x80,
            FOS_ALLOWMULTISELECT = 0x200,
            FOS_CREATEPROMPT = 0x2000,
            FOS_DEFAULTNOMINIMODE = 0x20000000,
            FOS_DONTADDTORECENT = 0x2000000,
            FOS_FILEMUSTEXIST = 0x1000,
            FOS_FORCEFILESYSTEM = 0x40,
            FOS_FORCESHOWHIDDEN = 0x10000000,
            FOS_HIDEMRUPLACES = 0x20000,
            FOS_HIDEPINNEDPLACES = 0x40000,
            FOS_NOCHANGEDIR = 8,
            FOS_NODEREFERENCELINKS = 0x100000,
            FOS_NOREADONLYRETURN = 0x8000,
            FOS_NOTESTFILECREATE = 0x10000,
            FOS_NOVALIDATE = 0x100,
            FOS_OVERWRITEPROMPT = 2,
            FOS_PATHMUSTEXIST = 0x800,
            FOS_PICKFOLDERS = 0x20,
            FOS_SHAREAWARE = 0x4000,
            FOS_STRICTFILETYPES = 4
        }
    }

    class EmptyRowsCheckSettings
    {
        public EmptyRowsCheckSettings(bool SwitchChecks, int EmptyRowsLimit, int EmptyColmLimit)
        {
            _SwitchChecks = SwitchChecks;
            _EmptyRowsLimit = EmptyRowsLimit;
            _EmptyColmLimit = EmptyColmLimit;
        }

        private bool _SwitchChecks;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("СheckRealRange")]
        [Description("Check the real range to exclude empty cells")]
        public bool SwitchChecks
        {
            get { return _SwitchChecks; }
            set { _SwitchChecks = value; }
        }

        private int _EmptyRowsLimit;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("EmptyRowsLimit")]
        [Description("Limits for empty rows, use more than 10 for save data")]
        public int EmptyRowsLimit
        {
            get { return _EmptyRowsLimit; }
            set { _EmptyRowsLimit = value; }
        }

        private int _EmptyColmLimit;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("EmptyColumnsLimit")]
        [Description("Limits for empty columns, use more than 10 for save data")]
        public int EmptyColmLimit
        {
            get { return _EmptyColmLimit; }
            set { _EmptyColmLimit = value; }
        }

        public override string ToString()
        {
            return SwitchChecks + " (RLim=" + EmptyRowsLimit + " CLim=" + EmptyColmLimit + ")";
        }
    }

    class ZoneEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            hoursTariffZone zone = value as hoursTariffZone;
            if (svc != null && zone != null)
            {
                using (hoursZoneEditor form = new hoursZoneEditor())
                {
                    form.typeList.SelectedIndex = 0;
                    form.cmbxSelectTypeZone.Items.AddRange(new[] { "день", "ночь" });
                    form.cmbxSelectTypeZone.SelectedIndex = 0;

                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {
                        Settings settings = (Settings)Application.OpenForms["Settings"];
                        settings = MainForm.SettingsForm;

                        settings._settings2dayZone_00 = form._2dayZone_00;
                        settings._settings2nightZone_00 = form._2nightZone_00;
                        settings._settings3peakZone_00 = form._3peakZone_00;
                        settings._settings3semiPeakZone_00 = form._3semiPeakZone_00;
                        settings._settings3nightZone_00 = form._3nightZone_00;

                        settings._settings2dayZone_01 = form._2dayZone_01;
                        settings._settings2nightZone_01 = form._2nightZone_01;
                        settings._settings3peakZone_01 = form._3peakZone_01;
                        settings._settings3semiPeakZone_01 = form._3semiPeakZone_01;
                        settings._settings3nightZone_01 = form._3nightZone_01;

                        settings.Focus();
                    }
                }
            }
            return value;
        }
    }

    class CompanyEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            companyDataEditor company = value as companyDataEditor;
            if (svc != null && company != null)
            {
                using (companyForm form = new companyForm())
                {
                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {

                    }
                }
            }
            return value;
        }
    }

    class SignedEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            signedDataEditor sign = value as signedDataEditor;
            if (svc != null && sign != null)
            {
                using (SignedForm form = new SignedForm())
                {
                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {
                        Settings settings = (Settings)Application.OpenForms["Settings"];
                        settings = MainForm.SettingsForm;

                        settings.settingsSignaturesDataSet = form.tempSignaturesDataSet;

                        foreach (DataTable tbl in settings.settingsSignaturesDataSet.Tables)
                        {
                            if (tbl.Rows.Count > 0)
                            {
                                Console.WriteLine("settingsTable:" + tbl.TableName);
                            }
                        }
                    }
                }
            }
            return value;
        }
    }

    class hoursTariffZone
    {
        public hoursTariffZone()
        {

        }

        private string _doubleZone;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("2Zone")]
        [Description("")]
        public string DoubleZone
        {
            get { return _doubleZone; }
            set { _doubleZone = value; }
        }

        private string _trippleZone;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("3Zone")]
        [Description("")]
        public string TrippleZone
        {
            get { return _trippleZone; }
            set { _trippleZone = value; }
        }

        public override string ToString()
        {
            return "Редактор тарифных зон суток...";
        }
    }

    class signedDataEditor
    {
        public signedDataEditor()
        {

        }

        private string _signFirstName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Фамилия")]
        [Description("")]
        public string signFirstName
        {
            get { return _signFirstName; }
            set { _signFirstName = value; }
        }

        private string _signLastName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Имя")]
        [Description("")]
        public string signLastName
        {
            get { return _signLastName; }
            set { _signLastName = value; }
        }

        private string _signMidName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Отчество")]
        [Description("")]
        public string signMidName
        {
            get { return _signMidName; }
            set { _signMidName = value; }
        }

        private string _signPosition;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Должность")]
        [Description("")]
        public string signPosition
        {
            get { return _signPosition; }
            set { _signPosition = value; }
        }

        private string _signAttorney;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Доверенность")]
        [Description("")]
        public string signAttorney
        {
            get { return _signAttorney; }
            set { _signAttorney = value; }
        }

        private int _signNumber;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Табельный номер")]
        [Description("")]
        public int signNumber
        {
            get { return _signNumber; }
            set { _signNumber = value; }
        }

        public override string ToString()
        {
            return "Редактор...";
        }
    }

    class companyDataEditor
    {
        public companyDataEditor()
        {

        }

        private string _RegionName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Регион")]
        [Description("")]
        public string RegionName
        {
            get { return _RegionName; }
            set { _RegionName = value; }
        }

        private string _companyName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Наименование участника")]
        [Description("")]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _GTPcode;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Код ГТП")]
        [Description("")]
        public string GTPcode
        {
            get { return _GTPcode; }
            set { _GTPcode = value; }
        }

        private string _GTPname;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Наименование ГТП")]
        [Description("")]
        public string GTPname
        {
            get { return _GTPname; }
            set { _GTPname = value; }
        }

        private int _INNcompany;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("ИНН")]
        [Description("")]
        public int INNcompany
        {
            get { return _INNcompany; }
            set { _INNcompany = value; }
        }

        private int _KPPcompany;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("КПП")]
        [Description("")]
        public int KPPcompany
        {
            get { return _KPPcompany; }
            set { _KPPcompany = value; }
        }

        private string _BankName;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Наименование банка")]
        [Description("")]
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }

        private int _BIKbank;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("БИК банка")]
        [Description("")]
        public int BIKbank
        {
            get { return _BIKbank; }
            set { _BIKbank = value; }
        }

        private int _Racc;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Расчетный счет")]
        [Description("")]
        public int BankRacc
        {
            get { return _Racc; }
            set { _Racc = value; }
        }

        private int _Cacc;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Кор.счет")]
        [Description("")]
        public int BankCacc
        {
            get { return _Cacc; }
            set { _Cacc = value; }
        }

        private string _legalAddress;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Юридический адрес")]
        [Description("")]
        public string LegalAddress
        {
            get { return _legalAddress; }
            set { _legalAddress = value; }
        }

        private string _postAddress;
        [Browsable(true)]
        [ReadOnly(false)]
        [DisplayName("Почтовый адрес")]
        [Description("")]
        public string PostAddress
        {
            get { return _postAddress; }
            set { _postAddress = value; }
        }

        public override string ToString()
        {
            return "Редактор...";
        }
    }

    class mgRegions
    {
        public mgRegions(string GTPName, string GTPcode)
        {
            _GTPName = GTPName;
            _GTPcode = GTPcode;
        }

        public static List<string> mgGTPnameList = ImportList.KnownGTPnames;
        private string _GTPName;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("GTPname")]
        [TypeConverter(typeof(mgListGTPnames))]
        public string propGTPname
        { get { return _GTPName; } set { _GTPName = value; } }


        private static List<string> mgGTPcodeList = ImportList.KnownGTPcode;
        private string _GTPcode;
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("")]
        [DisplayName("GTPcode")]
        [TypeConverter(typeof(mgListGTPcodes))]
        public string propGTPcode
        { get { return mgGTPcodeList[mgGTPnameList.IndexOf(propGTPname)]; } set { _GTPcode = value; } }

        public override string ToString()
        {
            return "name: " + propGTPname + " (code: " + mgGTPcodeList[mgGTPnameList.IndexOf(propGTPname)] + ")";
        }
    }


    class OleDBModeSets
    {
        public OleDBModeSets(string Version, bool HDR, uint IMEX)
        {
            _verOleDB = Version;
            _HDR = HDR;
            _IMEX = IMEX;
        }

        private string _verOleDB;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("The Microsoft OLE DB Provider for SQL Server, SQLOLEDB, allows ADO to access Microsoft SQL Server.")]
        [DisplayName("Provider")]
        [TypeConverter(typeof(ProvidersList))]
        public string VersionOleDB
        {
            get { return _verOleDB; }
            set { _verOleDB = value; }
        }

        private string[] ver { get { return VersionOleDB.Split('.'); } }

        private bool _HDR;
        [Browsable(true)]
        [DisplayName("HDR")]
        [Description("Indicates that the first row contains columnnames, not data")]
        [TypeConverter(typeof(BooleanTypeConverter))]
        public bool HDR
        {
            get { return _HDR; }
            set { _HDR = value; }
        }

        [Browsable(false)]
        public string strHDR { get { return _HDR ? "Yes" : "No"; } }


        private uint _IMEX;
        [Browsable(true)]
        [DisplayName("IMEX")]
        [Description("Tells the driver to always read “intermixed” (numbers, dates, strings etc) data columns as text")]
        public uint IMEX
        {
            get { return _IMEX; }
            set { _IMEX = value; }
        }

        public override string ToString()
        {
            if (VersionOleDB != "")
                return ver[3] + "." + ver[4] + " (HDR=" + strHDR + "; IMEX=" + IMEX + ")";
            else
                return "Method not available";
        }
    }

    class BooleanTypeConverter : BooleanConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
        {
            return (bool)value ?
              "Yes" : "No";
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            return (string)value == "Yes";
        }
    }


    class CollectionTypeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destType)
        {
            return destType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
        {
            return "(...)";
        }
    }

    public class GlobalStandarts : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {

            string[] standarts = { "ru-RU", "en-US" };

            return new StandardValuesCollection(standarts);
            return base.GetStandardValues(context);
        }
    }


    public class ListBoxForXml : TypeConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string path = Environment.CurrentDirectory + "\\";
            var dir = new DirectoryInfo(path);
            List<string> files = new List<string>();
            foreach (FileInfo file in dir.GetFiles("*.xml"))
            {
                files.Add(Path.GetFileName(file.FullName));
            }

            return new StandardValuesCollection(files);
            return base.GetStandardValues(context);
        }
    }

    public class StartPage : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(ImportList.AvailablePages);
            return base.GetStandardValues(context);
        }
    }

    public class mgListGTPnames : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<string> mgGTPnameList = ImportList.KnownGTPnames;

            return new StandardValuesCollection(mgGTPnameList);
            return base.GetStandardValues(context);
        }
    }

    public class mgListGTPcodes : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            List<string> mgGTPcodeList = ImportList.KnownGTPcode;

            return new StandardValuesCollection(mgGTPcodeList);
            return base.GetStandardValues(context);
        }
    }

    class ImportMode : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(ImportList.AvailableMode);
        }
    }

    class ProvidersList : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            return new StandardValuesCollection(ImportList.ProvidersList);
        }
    }

    class mgFolderProject
    {
        public mgFolderProject()
        {
        }

        private string _fullPathProject;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("FullPathToProject")]
        [Editor(typeof(CustomFolderNameEditor), typeof(UITypeEditor))]
        public string fullPathProject
        { get { return _fullPathProject; } set { _fullPathProject = value; } }

        public override string ToString()
        {
            return "...\\" + new DirectoryInfo(_fullPathProject).Name;
        }
    }

    class mgFolderAgreeDictionary
    {
        public mgFolderAgreeDictionary()
        {
        }

        private static List<string> mgKnownGTPnameList = ImportList.KnownGTPnames;

        private string _fullPathAgreeDictionary;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("fullPathAgreeDictionary")]
        [Editor(typeof(CustomFolderNameEditor), typeof(UITypeEditor))]
        public string fullPathAgreeDictionary
        { get { return _fullPathAgreeDictionary; } set { _fullPathAgreeDictionary = value; } }

        public override string ToString()
        {
            foreach (string findProject in mgKnownGTPnameList)
            {
                if (_fullPathAgreeDictionary.Contains(findProject))
                {
                    return "...\\" + findProject + "\\" + new DirectoryInfo(_fullPathAgreeDictionary).Name;
                    break;
                }
                else
                {
                    return "...\\" + new DirectoryInfo(_fullPathAgreeDictionary).Name;
                }
            }
            return "...\\" + new DirectoryInfo(_fullPathAgreeDictionary).Name;
        }
    }

    class mgFolderBanksDictionary
    {
        public mgFolderBanksDictionary()
        {
        }

        private static List<string> mgKnownGTPnameList = ImportList.KnownGTPnames;

        private string _fullPathBanksDictionary;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("fullPathBanksDictionary")]
        [Editor(typeof(CustomFolderNameEditor), typeof(UITypeEditor))]
        public string fullPathBanksDictionary
        { get { return _fullPathBanksDictionary; } set { _fullPathBanksDictionary = value; } }

        public override string ToString()
        {
            foreach (string findProject in mgKnownGTPnameList)
            {
                if (_fullPathBanksDictionary.Contains(findProject))
                {
                    return "...\\" + findProject + "\\" + new DirectoryInfo(_fullPathBanksDictionary).Name;
                    break;
                }
                else
                {
                    return "...\\" + new DirectoryInfo(_fullPathBanksDictionary).Name;
                }
            }
            return "...\\" + new DirectoryInfo(_fullPathBanksDictionary).Name;
        }
    }

    class mgFolderDownloads
    {
        public mgFolderDownloads()
        {
        }

        private static List<string> mgKnownGTPnameList = ImportList.KnownGTPnames;

        private string _fullPathDownloads;
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("")]
        [DisplayName("fullPathBanksDictionary")]
        [Editor(typeof(CustomFolderNameEditor), typeof(UITypeEditor))]
        public string fullPathDownloads
        { get { return _fullPathDownloads; } set { _fullPathDownloads = value; } }

        public override string ToString()
        {
            foreach (string findProject in mgKnownGTPnameList)
            {
                if (_fullPathDownloads.Contains(findProject))
                {
                    return "...\\" + findProject + "\\" + new DirectoryInfo(_fullPathDownloads).Name;
                    break;
                }
                else
                {
                    return "...\\" + new DirectoryInfo(_fullPathDownloads).Name;
                }
            }
            return "...\\" + new DirectoryInfo(_fullPathDownloads).Name;
        }
    }

}
