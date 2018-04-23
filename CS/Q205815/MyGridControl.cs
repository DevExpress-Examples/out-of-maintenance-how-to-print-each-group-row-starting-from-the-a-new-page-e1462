using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using System.Drawing;

namespace DXSample {
    public class MyGridControl : GridControl {
        public MyGridControl() : base() { }
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }
    public class MyGridView : GridView {
        public MyGridView() : base() { }
        public MyGridView(GridControl gridControl) : base(gridControl) { }
        internal const string MyGridViewName = "MyGridView";
        protected override string ViewName { get { return MyGridViewName; } }
        protected override BaseViewPrintInfo CreatePrintInfoInstance(PrintInfoArgs args) {
            return new MyGridViewPrintInfo(args);
        }
    }
    public class MyGridViewInfoRegistrator : GridInfoRegistrator {
        public MyGridViewInfoRegistrator() : base() { }
        public override string ViewName { get { return MyGridView.MyGridViewName; } }
        public override BaseView CreateView(GridControl grid) {
            return new MyGridView(grid);
        }
    }
    public class MyGridViewPrintInfo : GridViewPrintInfo {
        public MyGridViewPrintInfo(PrintInfoArgs args) : base(args) { }
        protected override void PrintGroupRow(int rowHandle, int level) {
            Rectangle r = Rectangle.Empty;
            r.X = Indent + level * ViewViewInfo.LevelIndent;
            r.Width = this.fMaxRowWidth - r.Left;
            r.Y = Y;
            r.Height = CurrentRowHeight;
            SetDefaultBrickStyle(Graph, Bricks["GroupRow"]);
            Brick brick = (Brick)DrawTextBrick(Graph, View.GetGroupRowDisplayText(rowHandle), r, true);
            if (Y != 0)
                ((PSLinkDocument)((PrintingSystemBase)PS).Document).ShowFromNewPage(brick);
            Y += r.Height;
        }
    }
}