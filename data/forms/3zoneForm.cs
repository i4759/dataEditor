﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataEditor
{
    public partial class FormType3 : Form
    {
        public FormType3()
        {
            InitializeComponent();
        }

        private void mainTableLayoutGridBorder(object sender, TableLayoutCellPaintEventArgs e)
        {
            var panel = sender as TableLayoutPanel;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            var rectangle = e.CellBounds;
            using (var pen = new Pen(Color.Black, 1))
            {
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

                if (e.Row == (panel.RowCount - 1))
                {
                    rectangle.Height -= 1;
                }

                if (e.Column == (panel.ColumnCount - 1))
                {
                    rectangle.Width -= 1;
                }

                e.Graphics.DrawRectangle(pen, rectangle);
            }
        }

        private void useIntervals_CheckedChanged(object sender, EventArgs e)
        {
            if (useIntervals.Checked == true)
                useHours.Checked = false;
            else
                useHours.Checked = true;
        }

        private void useHours_CheckedChanged(object sender, EventArgs e)
        {
            if (useHours.Checked == true)
                useIntervals.Checked = false;
            else
                useIntervals.Checked = true;
        }
    }
}