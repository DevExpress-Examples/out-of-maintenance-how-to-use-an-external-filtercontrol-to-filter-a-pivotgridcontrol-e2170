using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            myPivotGridControl1.BeginUpdate();
            myPivotGridControl1.DataSource = CreateDataSource();
            myPivotGridControl1.RetrieveFields();
            myPivotGridControl1.Fields["RowField1"].Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            myPivotGridControl1.Fields["ColumnField1"].Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            myPivotGridControl1.Fields["DataField1"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            myPivotGridControl1.Fields["DataField2"].Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            myPivotGridControl1.EndUpdate();
            filterControl1.SourceControl = myPivotGridControl1.FilterSourceControl;
        }

        private DataTable CreateDataSource() {
            DataTable table = new DataTable();
            table.Columns.Add("RowField1");
            table.Columns.Add("ColumnField1");
            table.Columns.Add("DataField1", typeof(Int32));
            table.Columns.Add("DataField2", typeof(Int32));
            table.Columns.Add("DataField3", typeof(Int32));
            table.Rows.Add(1, 1, 1, 2, null);
            table.Rows.Add(2, 1, 2, 3, null);
            table.Rows.Add(3, 1, 3, 5, null);
            table.Rows.Add(4, 2, 1, 3, 5);
            table.Rows.Add(5, 2, 2, 1, 4);
            return table;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            filterControl1.ApplyFilter();
        }
    }
}
