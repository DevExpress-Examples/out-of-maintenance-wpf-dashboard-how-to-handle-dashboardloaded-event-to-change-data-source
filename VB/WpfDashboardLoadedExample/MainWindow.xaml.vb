Imports DevExpress.DashboardCommon
Imports DevExpress.DataAccess.Excel
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Dialogs

Namespace WpfDashboardLoadedExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits ThemedWindow

        Private dashboardExcelDataFileName As String = "Data\Sales.xlsx"
        Private dashboardFileName As String = "Data\Sales.xml"

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub BarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim fileDialog As New DXOpenFileDialog()
            fileDialog.InitialDirectory = "C:\DATA"
            fileDialog.Filter = "Excel File | *.xlsx"
            fileDialog.Title = "Select XLSX File"
            If fileDialog.ShowDialog() = True Then
                dashboardExcelDataFileName = fileDialog.FileName
                dashboardControl.LoadDashboard(dashboardFileName)
            End If
        End Sub

        Private Sub DashboardControl_DashboardLoaded(ByVal sender As Object, ByVal e As DevExpress.DashboardWpf.DashboardLoadedEventArgs)
            Dim excelDataSource = TryCast(e.Dashboard.DataSources.FindFirst(Function(i) i.ComponentName = "dashboardExcelDataSource1"), DashboardExcelDataSource)
            If excelDataSource IsNot Nothing Then
                excelDataSource.FileName = dashboardExcelDataFileName
                Dim worksheetSettings As New ExcelWorksheetSettings("Bike Data")
                excelDataSource.SourceOptions = New ExcelSourceOptions(worksheetSettings)
                excelDataSource.Fill()
            End If
        End Sub
    End Class
End Namespace
