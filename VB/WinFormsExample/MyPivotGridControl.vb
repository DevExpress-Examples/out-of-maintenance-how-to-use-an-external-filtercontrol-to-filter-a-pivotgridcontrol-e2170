Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraEditors.Filtering

Namespace WinFormsExample
	Public Class MyPivotGridControl
		Inherits PivotGridControl
		Public Sub New()
			Me.OptionsCustomization.AllowPrefilter = False
		End Sub
		Protected Overrides Function CreateData() As PivotGridViewInfoData
			Dim data As PivotGridViewInfoData = MyBase.CreateData()
			_FilterSourceControl = data
			Return data
		End Function
		Private _FilterSourceControl As IFilteredComponent
		Public ReadOnly Property FilterSourceControl() As IFilteredComponent
			Get
				Return _FilterSourceControl
			End Get
		End Property
	End Class
End Namespace
