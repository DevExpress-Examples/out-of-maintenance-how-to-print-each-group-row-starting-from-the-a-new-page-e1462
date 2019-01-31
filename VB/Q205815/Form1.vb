Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace Q205815
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            myGridControl1.DataSource = GetPersonDataTable()

        End Sub
        Private Function GetPersonDataTable() As DataTable
            Dim table As New DataTable()
            table.TableName = "Persons"
            table.Columns.Add(New DataColumn("FirstName", GetType(String)))
            table.Columns.Add(New DataColumn("SecondName", GetType(String)))
            table.Columns.Add(New DataColumn("Age", GetType(Integer)))
            table.Columns.Add(New DataColumn("ID", GetType(Integer)))
            For i As Integer = 0 To 149
                table.Rows.Add("FirstName " & i, "SecondName " & i, 20 + i \ 15, i)
            Next i
            Return table
        End Function
        Private Sub OnShowPrintPreviewSimpleButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            myGridControl1.ShowPrintPreview()
        End Sub
    End Class
End Namespace