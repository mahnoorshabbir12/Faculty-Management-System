using System;
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

namespace WindowsFormsApp1
{
    public partial class ReportForm: Form
    {
        public ReportForm()
        {
            InitializeComponent();
            DataTable dt = FacultyRequestsDL.GetDT();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.LocalReport.Refresh();
            reportViewer2.RefreshReport();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = FacultyRequestsDL.GetDT();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.LocalReport.Refresh();
            reportViewer2.RefreshReport();
        }
    }
    
}
