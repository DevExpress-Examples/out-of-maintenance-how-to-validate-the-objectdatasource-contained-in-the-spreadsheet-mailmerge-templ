#Region "#usings"
Imports DevExpress.DataAccess.ObjectBinding
Imports DevExpress.XtraSpreadsheet.Services
#End Region ' #usings
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms


Namespace ObjectDataSourceMailMergeExample
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
'            #Region "#ObjectDataSourceLoadingBehavior"
            spreadsheetControl1.Options.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.Prompt
'            #End Region ' #ObjectDataSourceLoadingBehavior
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ribbonControl1.SelectedPage = mailMergeRibbonPage1
        End Sub

        Private Sub barCheckCustomValidationService_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barCheckCustomValidationService.CheckedChanged
'            #Region "#ReplaceService"
            If barCheckCustomValidationService.Checked Then
                spreadsheetControl1.ReplaceService(Of IObjectDataSourceValidationService)(New MyObjectDataSourceValidationService())
            Else
                spreadsheetControl1.ReplaceService(Of IObjectDataSourceValidationService)(New ObjectDataSourceValidationService(spreadsheetControl1))
            End If
'            #End Region ' #ReplaceService
        End Sub

        Private Sub barBtnLoadTemplate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnLoadTemplate.ItemClick
            spreadsheetControl1.LoadDocument("EmployeesMailMergeTemplate.xlsx")
        End Sub
    End Class

    #Region "#MyObjectDataSourceValidationService"
    Public Class MyObjectDataSourceValidationService
        Implements IObjectDataSourceValidationService

        Public Sub Validate(ByVal dataSources As IEnumerable(Of ObjectDataSource)) Implements IObjectDataSourceValidationService.Validate
            ' Do nothing to allow loading.
            ' Clear the DataSource and DataMember properties to prohibit loading.
            For Each ds As ObjectDataSource In dataSources
                ds.DataSource = Nothing
                ds.DataMember = Nothing
            Next ds
        End Sub
    End Class
    #End Region ' #MyObjectDataSourceValidationService
End Namespace
