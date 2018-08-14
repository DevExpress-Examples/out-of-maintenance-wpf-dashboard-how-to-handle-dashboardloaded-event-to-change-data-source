# How to Change the Dashboard Data Source Using the DashboardLoaded Event

This example handles the [DashboardControl.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.DashboardLoaded) event to prompt the user for a new Excel file containing dashboard data and update the dashboard's data source.

Run the project and click the **Select File to Load Data** [custom button](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.TitleCustomizationsTemplate) in the dashboard title. The **DXOpenFileDialog** window prompts for the Excel file to populate the [DashboardExcelDataSource](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardExcelDataSource) instance with data.