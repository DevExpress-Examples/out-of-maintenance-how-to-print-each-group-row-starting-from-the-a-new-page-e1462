Partial Class Form1
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.myGridControl1 = New DXSample.MyGridControl()
        Me.myGridView1 = New DXSample.MyGridView()
        Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'myGridControl1
        '
        Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.myGridControl1.MainView = Me.myGridView1
        Me.myGridControl1.Name = "myGridControl1"
        Me.myGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1})
        Me.myGridControl1.Size = New System.Drawing.Size(762, 524)
        Me.myGridControl1.TabIndex = 0
        Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1})
        '
        'myGridView1
        '
        Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4})
        Me.myGridView1.GridControl = Me.myGridControl1
        Me.myGridView1.GroupCount = 1
        Me.myGridView1.Name = "myGridView1"
        Me.myGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'gridColumn1
        '
        Me.gridColumn1.Caption = "FirstName"
        Me.gridColumn1.FieldName = "FirstName"
        Me.gridColumn1.Name = "gridColumn1"
        Me.gridColumn1.Visible = True
        Me.gridColumn1.VisibleIndex = 0
        '
        'gridColumn2
        '
        Me.gridColumn2.Caption = "SecondName"
        Me.gridColumn2.FieldName = "SecondName"
        Me.gridColumn2.Name = "gridColumn2"
        Me.gridColumn2.Visible = True
        Me.gridColumn2.VisibleIndex = 1
        '
        'gridColumn3
        '
        Me.gridColumn3.Caption = "Age"
        Me.gridColumn3.FieldName = "Age"
        Me.gridColumn3.Name = "gridColumn3"
        Me.gridColumn3.Visible = True
        Me.gridColumn3.VisibleIndex = 2
        '
        'gridColumn4
        '
        Me.gridColumn4.Caption = "ID"
        Me.gridColumn4.FieldName = "ID"
        Me.gridColumn4.Name = "gridColumn4"
        Me.gridColumn4.Visible = True
        Me.gridColumn4.VisibleIndex = 2
        '
        'repositoryItemLookUpEdit1
        '
        Me.repositoryItemLookUpEdit1.AutoHeight = False
        Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemLookUpEdit1.DisplayMember = "CategoryName"
        Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
        Me.repositoryItemLookUpEdit1.ValueMember = "CategoryID"
        '
        'panelControl1
        '
        Me.panelControl1.Controls.Add(Me.simpleButton1)
        Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControl1.Location = New System.Drawing.Point(0, 524)
        Me.panelControl1.Name = "panelControl1"
        Me.panelControl1.Size = New System.Drawing.Size(762, 32)
        Me.panelControl1.TabIndex = 1
        '
        'simpleButton1
        '
        Me.simpleButton1.Location = New System.Drawing.Point(5, 5)
        Me.simpleButton1.Name = "simpleButton1"
        Me.simpleButton1.Size = New System.Drawing.Size(104, 23)
        Me.simpleButton1.TabIndex = 0
        Me.simpleButton1.Text = "Show Print Preview"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 556)
        Me.Controls.Add(Me.myGridControl1)
        Me.Controls.Add(Me.panelControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private myGridControl1 As DXSample.MyGridControl
    Private panelControl1 As DevExpress.XtraEditors.PanelControl
    Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Private myGridView1 As DXSample.MyGridView
    Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
