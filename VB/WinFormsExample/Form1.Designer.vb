Imports Microsoft.VisualBasic
Imports System
Namespace WinFormsExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.myPivotGridControl1 = New WinFormsExample.MyPivotGridControl()
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' filterControl1
			' 
			Me.filterControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.filterControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.filterControl1.Location = New System.Drawing.Point(0, 249)
			Me.filterControl1.Name = "filterControl1"
			Me.filterControl1.Size = New System.Drawing.Size(637, 108)
			Me.filterControl1.TabIndex = 1
			Me.filterControl1.Text = "filterControl1"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton1.Location = New System.Drawing.Point(550, 322)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Apply"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' myPivotGridControl1
			' 
			Me.myPivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myPivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.myPivotGridControl1.Name = "myPivotGridControl1"
			Me.myPivotGridControl1.Size = New System.Drawing.Size(637, 249)
			Me.myPivotGridControl1.TabIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(637, 357)
			Me.Controls.Add(Me.myPivotGridControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.filterControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.myPivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private filterControl1 As DevExpress.XtraEditors.FilterControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private myPivotGridControl1 As WinFormsExample.MyPivotGridControl
	End Class
End Namespace

