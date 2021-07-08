<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfDashboardLoadedExample/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/WpfDashboardLoadedExample/MainWindow.xaml.cs)
<!-- default file list end -->

# Dashboard for WPF - How to change the Dashboard data source using the DashboardLoaded event

This example handles the [DashboardControl.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardLoaded) event to prompt the user for a new Excel file containing dashboard data and update the dashboard's data source.

Run the project and click the **Select File to Load Data** [custom button](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.TitleCustomizationsTemplate) in the dashboard title. The **DXOpenFileDialog** window prompts for the Excel file to populate the [DashboardExcelDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExcelDataSource) instance with data.

## Documentation

- [Dashboard](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard)
- [DashboardControl](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl)
- [Providing Data](https://docs.devexpress.com/Dashboard/119901/wpf-viewer/providing-data)
