Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Drawing

Namespace DXSample

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub InitData()
            For i As Integer = 0 To 5 - 1
                dataSet11.Tables(CInt(0)).Rows.Add(New Object() {i, String.Format("FirstName {0}", i), String.Format("LastName {0}", i), 20 + i})
            Next
        End Sub

        Private helper As AutoHeightHelper

        Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs)
            InitData()
            gridControl1.ForceInitialize()
            helper = New AutoHeightHelper(gridView1)
            helper.EnableColumnPanelAutoHeight()
        End Sub

        Private Overloads Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            helper.DisableColumnPanelAutoHeight()
        End Sub
    End Class
End Namespace
