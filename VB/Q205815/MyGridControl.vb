Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Native
Imports System.Drawing

Namespace DXSample

    Public Class MyGridControl
        Inherits GridControl

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
            MyBase.RegisterAvailableViewsCore(collection)
            collection.Add(New MyGridViewInfoRegistrator())
        End Sub
    End Class

    Public Class MyGridView
        Inherits GridView

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal gridControl As GridControl)
            MyBase.New(gridControl)
        End Sub

        Friend Const MyGridViewName As String = "MyGridView"

        Protected Overrides ReadOnly Property ViewName As String
            Get
                Return MyGridViewName
            End Get
        End Property

        Protected Overrides Function CreatePrintInfoInstance(ByVal args As PrintInfoArgs) As BaseViewPrintInfo
            Return New MyGridViewPrintInfo(args)
        End Function
    End Class

    Public Class MyGridViewInfoRegistrator
        Inherits GridInfoRegistrator

        Public Sub New()
            MyBase.New()
        End Sub

        Public Overrides ReadOnly Property ViewName As String
            Get
                Return MyGridView.MyGridViewName
            End Get
        End Property

        Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
            Return New MyGridView(grid)
        End Function
    End Class

    Public Class MyGridViewPrintInfo
        Inherits GridViewPrintInfo

        Public Sub New(ByVal args As PrintInfoArgs)
            MyBase.New(args)
        End Sub

        Protected Overrides Sub PrintGroupRow(ByVal rowHandle As Integer, ByVal level As Integer)
            Dim r As Rectangle = Rectangle.Empty
            r.X = Indent + level * ViewViewInfo.LevelIndent
            r.Width = Me.fMaxRowWidth - r.Left
            r.Y = Y
            r.Height = CurrentRowHeight
            SetDefaultBrickStyle(Graph, Bricks("GroupRow"))
            Dim brick As Brick = CType(DrawTextBrick(Graph, View.GetGroupRowDisplayText(rowHandle), r, True), Brick)
            If Y <> 0 Then CType(CType(PrintingSystemBase, PrintingSystemBase).Document, PSLinkDocument).ShowFromNewPage(brick)
            Y += r.Height
        End Sub
    End Class
End Namespace
