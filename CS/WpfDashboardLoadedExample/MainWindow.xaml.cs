using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Excel;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Dialogs;

namespace WpfDashboardLoadedExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        string dashboardExcelDataFileName = @"Data\Sales.xlsx";
        string dashboardFileName = @"Data\Sales.xml";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BarButtonItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            DXOpenFileDialog fileDialog = new DXOpenFileDialog();
            fileDialog.InitialDirectory = @"C:\DATA";
            fileDialog.Filter = "Excel File | *.xlsx";
            fileDialog.Title = "Select XLSX File";
            if (fileDialog.ShowDialog() == true)
            {
                dashboardExcelDataFileName = fileDialog.FileName;
                dashboardControl.LoadDashboard(dashboardFileName);
            }
        }

        private void DashboardControl_DashboardLoaded(object sender, DevExpress.DashboardWpf.DashboardLoadedEventArgs e)
        {
            var excelDataSource = e.Dashboard.DataSources.FindFirst(i => i.ComponentName == "dashboardExcelDataSource1") as DashboardExcelDataSource;
            if (excelDataSource != null)
            {
                excelDataSource.FileName = dashboardExcelDataFileName;
                ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Bike Data");
                excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
                excelDataSource.Fill();
            }
        }
    }
}
