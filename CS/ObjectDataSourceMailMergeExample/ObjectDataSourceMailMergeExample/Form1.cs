#region #usings
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraSpreadsheet.Services;
#endregion #usings
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace ObjectDataSourceMailMergeExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            #region #ObjectDataSourceLoadingBehavior
            spreadsheetControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.Prompt;
            #endregion #ObjectDataSourceLoadingBehavior
        }

        private void Form1_Load(object sender, EventArgs e) {
            ribbonControl1.SelectedPage = mailMergeRibbonPage1;
        }

        private void barCheckCustomValidationService_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            #region #ReplaceService
            if (barCheckCustomValidationService.Checked) {
                spreadsheetControl1.ReplaceService<IObjectDataSourceValidationService>(new MyObjectDataSourceValidationService());
            }
            else {
                spreadsheetControl1.ReplaceService<IObjectDataSourceValidationService>(new ObjectDataSourceValidationService(spreadsheetControl1));
            }
            #endregion #ReplaceService
        }

        private void barBtnLoadTemplate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            spreadsheetControl1.LoadDocument("EmployeesMailMergeTemplate.xlsx");
        }
    }

    #region #MyObjectDataSourceValidationService
    public class MyObjectDataSourceValidationService : IObjectDataSourceValidationService {
        public void Validate(IEnumerable<ObjectDataSource> dataSources) {
            // Do nothing to allow loading.
            // Clear the DataSource and DataMember properties to prohibit loading.
            foreach (ObjectDataSource ds in dataSources) {
                ds.DataSource = null;
                ds.DataMember = null;
            };
        }
    }
    #endregion #MyObjectDataSourceValidationService
}
