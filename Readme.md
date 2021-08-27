<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/144736151/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830543)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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
