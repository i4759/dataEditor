﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataEditor
{

    public partial class StartScreen : Form
    {
        public static mgForm microgenerationForm = new mgForm();
        public static MainForm universalReaderForm = new MainForm();
        public StartScreen()
        {
            InitializeComponent();
            this.labelVersion.Text = String.Format("version {0}", Application.ProductVersion);
            this.labelBuild.Text = String.Format("build: {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            if (File.Exists(Environment.CurrentDirectory + "\\RELEASE-NOTES.txt"))
                this.ChangeLogBox.Text = File.ReadAllText(Environment.CurrentDirectory + "\\RELEASE-NOTES.txt");
        }

        private void startMG_Click(object sender, EventArgs e)
        {
            microgenerationForm.Show();
            this.Hide();
        }

        private void startUR_Click(object sender, EventArgs e)
        {
            universalReaderForm.Show();
            this.Hide();
        }
    }
}