using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraEditors.Filtering;

namespace WinFormsExample {
    public class MyPivotGridControl : PivotGridControl {
        public MyPivotGridControl() {
            this.OptionsCustomization.AllowPrefilter = false;
        }
        protected override PivotGridViewInfoData CreateData() {
            PivotGridViewInfoData data = base.CreateData();
            _FilterSourceControl = data;
            return data;
        }
        private IFilteredComponent _FilterSourceControl;
        public IFilteredComponent FilterSourceControl {
            get {
                return _FilterSourceControl;
            }
        }
    }
}
