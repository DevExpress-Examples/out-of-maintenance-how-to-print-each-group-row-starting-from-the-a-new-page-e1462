Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace Q205815
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Categories' table. You can move, or remove it, as needed.
			Me.categoriesTableAdapter.Fill(Me.nwindDataSet.Categories)
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub OnShowPrintPreviewSimpleButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			myGridControl1.ShowPrintPreview()
		End Sub
	End Class
End Namespace