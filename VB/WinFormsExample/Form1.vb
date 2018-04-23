Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WinFormsExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			myPivotGridControl1.BeginUpdate()
			myPivotGridControl1.DataSource = CreateDataSource()
			myPivotGridControl1.RetrieveFields()
			myPivotGridControl1.Fields("RowField1").Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			myPivotGridControl1.Fields("ColumnField1").Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			myPivotGridControl1.Fields("DataField1").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			myPivotGridControl1.Fields("DataField2").Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			myPivotGridControl1.EndUpdate()
			filterControl1.SourceControl = myPivotGridControl1.FilterSourceControl
		End Sub

		Private Function CreateDataSource() As DataTable
			Dim table As New DataTable()
			table.Columns.Add("RowField1")
			table.Columns.Add("ColumnField1")
			table.Columns.Add("DataField1", GetType(Int32))
			table.Columns.Add("DataField2", GetType(Int32))
			table.Columns.Add("DataField3", GetType(Int32))
			table.Rows.Add(1, 1, 1, 2, Nothing)
			table.Rows.Add(2, 1, 2, 3, Nothing)
			table.Rows.Add(3, 1, 3, 5, Nothing)
			table.Rows.Add(4, 2, 1, 3, 5)
			table.Rows.Add(5, 2, 2, 1, 4)
			Return table
		End Function

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			filterControl1.ApplyFilter()
		End Sub
	End Class
End Namespace
