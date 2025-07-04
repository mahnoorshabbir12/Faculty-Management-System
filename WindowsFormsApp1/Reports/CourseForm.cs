﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using WindowsFormsApp1.DL;

namespace WindowsFormsApp1.Reports
{
    public partial class CourseForm: Form
    {
        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

            DataTable dt = AdminCourseScheduleDL.GetDataTable();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
