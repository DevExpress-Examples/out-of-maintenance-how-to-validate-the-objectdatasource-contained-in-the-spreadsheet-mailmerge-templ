Namespace ObjectDataSourceMailMergeExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barCheckCustomValidationService = New DevExpress.XtraBars.BarCheckItem()
            Me.barBtnLoadTemplate = New DevExpress.XtraBars.BarButtonItem()
            Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup()
            Me.mailMergeRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage()
            Me.mailMergeDataRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup()
            Me.mailMergeModeRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup()
            Me.mailMergeExtendedRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup()
            Me.mailMergeGroupingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup()
            Me.mailMergeFilteringRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup()
            Me.mailMergeBindingRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
            Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
            Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
            Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.fieldListDockPanel1 = New DevExpress.XtraSpreadsheet.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.mailMergeParametersDockPanel1 = New DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel()
            Me.mailMergeParametersDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelContainer1.SuspendLayout()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.mailMergeParametersDockPanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 178)
            Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Import.Csv.Encoding = (CType(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding))
            Me.spreadsheetControl1.Options.Import.Txt.Encoding = (CType(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding))
            Me.spreadsheetControl1.Size = New System.Drawing.Size(584, 383)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem13, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarButtonItem15, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarCheckItem4, Me.spreadsheetCommandBarCheckItem5, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarButtonItem29, Me.barCheckCustomValidationService, Me.barBtnLoadTemplate})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 42
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.mailMergeRibbonPage1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(784, 146)
            ' 
            ' spreadsheetCommandBarButtonItem1
            ' 
            Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
            Me.spreadsheetCommandBarButtonItem1.Id = 1
            Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
            ' 
            ' spreadsheetCommandBarButtonItem2
            ' 
            Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
            Me.spreadsheetCommandBarButtonItem2.Id = 2
            Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
            ' 
            ' spreadsheetCommandBarButtonItem3
            ' 
            Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
            Me.spreadsheetCommandBarButtonItem3.Id = 3
            Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
            ' 
            ' spreadsheetCommandBarButtonItem4
            ' 
            Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
            Me.spreadsheetCommandBarButtonItem4.Id = 4
            Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
            ' 
            ' spreadsheetCommandBarButtonItem5
            ' 
            Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
            Me.spreadsheetCommandBarButtonItem5.Id = 5
            Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
            ' 
            ' spreadsheetCommandBarButtonItem6
            ' 
            Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
            Me.spreadsheetCommandBarButtonItem6.Id = 6
            Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
            ' 
            ' spreadsheetCommandBarButtonItem7
            ' 
            Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
            Me.spreadsheetCommandBarButtonItem7.Id = 7
            Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
            ' 
            ' spreadsheetCommandBarButtonItem8
            ' 
            Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
            Me.spreadsheetCommandBarButtonItem8.Id = 8
            Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
            ' 
            ' spreadsheetCommandBarButtonItem9
            ' 
            Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
            Me.spreadsheetCommandBarButtonItem9.Id = 9
            Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
            ' 
            ' spreadsheetCommandBarButtonItem10
            ' 
            Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
            Me.spreadsheetCommandBarButtonItem10.Id = 10
            Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
            ' 
            ' spreadsheetCommandBarButtonItem11
            ' 
            Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
            Me.spreadsheetCommandBarButtonItem11.Id = 11
            Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
            ' 
            ' spreadsheetCommandBarButtonItem12
            ' 
            Me.spreadsheetCommandBarButtonItem12.CommandName = "MailMergeAddDataSource"
            Me.spreadsheetCommandBarButtonItem12.Id = 12
            Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
            Me.spreadsheetCommandBarButtonItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem1
            ' 
            Me.spreadsheetCommandBarSubItem1.CommandName = "MailMergeManageRelationsCommandGroup"
            Me.spreadsheetCommandBarSubItem1.Id = 13
            Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem14) _
            })
            Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
            Me.spreadsheetCommandBarSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem13
            ' 
            Me.spreadsheetCommandBarButtonItem13.CommandName = "MailMergeManageQueriesCommand"
            Me.spreadsheetCommandBarButtonItem13.Id = 14
            Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
            ' 
            ' spreadsheetCommandBarButtonItem14
            ' 
            Me.spreadsheetCommandBarButtonItem14.CommandName = "MailMergeManageRelationsCommand"
            Me.spreadsheetCommandBarButtonItem14.Id = 15
            Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
            ' 
            ' spreadsheetCommandBarSubItem2
            ' 
            Me.spreadsheetCommandBarSubItem2.CommandName = "MailMergeManageDataSourceCommandGroup"
            Me.spreadsheetCommandBarSubItem2.Id = 16
            Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem15), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem16), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem17) _
            })
            Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
            Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem15
            ' 
            Me.spreadsheetCommandBarButtonItem15.CommandName = "MailMergeSelectDataSource"
            Me.spreadsheetCommandBarButtonItem15.Id = 17
            Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
            ' 
            ' spreadsheetCommandBarButtonItem16
            ' 
            Me.spreadsheetCommandBarButtonItem16.CommandName = "MailMergeSelectDataMember"
            Me.spreadsheetCommandBarButtonItem16.Id = 18
            Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
            ' 
            ' spreadsheetCommandBarButtonItem17
            ' 
            Me.spreadsheetCommandBarButtonItem17.CommandName = "MailMergeManageDataSourcesCommand"
            Me.spreadsheetCommandBarButtonItem17.Id = 19
            Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
            ' 
            ' spreadsheetCommandBarCheckItem1
            ' 
            Me.spreadsheetCommandBarCheckItem1.CommandName = "MailMergeDocumentsMode"
            Me.spreadsheetCommandBarCheckItem1.Id = 20
            Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
            Me.spreadsheetCommandBarCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem2
            ' 
            Me.spreadsheetCommandBarCheckItem2.CommandName = "MailMergeOneDocumentMode"
            Me.spreadsheetCommandBarCheckItem2.Id = 21
            Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
            Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem3
            ' 
            Me.spreadsheetCommandBarCheckItem3.CommandName = "MailMergeOneSheetMode"
            Me.spreadsheetCommandBarCheckItem3.Id = 22
            Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
            Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem3
            ' 
            Me.spreadsheetCommandBarSubItem3.CommandName = "MailMergeOrientationCommandGroup"
            Me.spreadsheetCommandBarSubItem3.Id = 23
            Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem5) _
            })
            Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
            Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarCheckItem4
            ' 
            Me.spreadsheetCommandBarCheckItem4.CommandName = "MailMergeHorizontalMode"
            Me.spreadsheetCommandBarCheckItem4.Id = 24
            Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
            ' 
            ' spreadsheetCommandBarCheckItem5
            ' 
            Me.spreadsheetCommandBarCheckItem5.CommandName = "MailMergeVerticalMode"
            Me.spreadsheetCommandBarCheckItem5.Id = 25
            Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
            ' 
            ' spreadsheetCommandBarButtonItem18
            ' 
            Me.spreadsheetCommandBarButtonItem18.CommandName = "MailMergeSetHeaderRange"
            Me.spreadsheetCommandBarButtonItem18.Id = 26
            Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
            Me.spreadsheetCommandBarButtonItem18.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem19
            ' 
            Me.spreadsheetCommandBarButtonItem19.CommandName = "MailMergeSetFooterRange"
            Me.spreadsheetCommandBarButtonItem19.Id = 27
            Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
            Me.spreadsheetCommandBarButtonItem19.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem20
            ' 
            Me.spreadsheetCommandBarButtonItem20.CommandName = "MailMergeSetDetailRange"
            Me.spreadsheetCommandBarButtonItem20.Id = 28
            Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
            Me.spreadsheetCommandBarButtonItem20.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem4
            ' 
            Me.spreadsheetCommandBarSubItem4.CommandName = "EditingMailMergeMasterDetailCommandGroup"
            Me.spreadsheetCommandBarSubItem4.Id = 29
            Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22) _
            })
            Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
            Me.spreadsheetCommandBarSubItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem21
            ' 
            Me.spreadsheetCommandBarButtonItem21.CommandName = "MailMergeSetDetailLevel"
            Me.spreadsheetCommandBarButtonItem21.Id = 30
            Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
            ' 
            ' spreadsheetCommandBarButtonItem22
            ' 
            Me.spreadsheetCommandBarButtonItem22.CommandName = "MailMergeSetDetailDataMember"
            Me.spreadsheetCommandBarButtonItem22.Id = 31
            Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
            ' 
            ' spreadsheetCommandBarButtonItem23
            ' 
            Me.spreadsheetCommandBarButtonItem23.CommandName = "MailMergeResetRange"
            Me.spreadsheetCommandBarButtonItem23.Id = 32
            Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
            Me.spreadsheetCommandBarButtonItem23.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem24
            ' 
            Me.spreadsheetCommandBarButtonItem24.CommandName = "MailMergeSetGroup"
            Me.spreadsheetCommandBarButtonItem24.Id = 33
            Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
            Me.spreadsheetCommandBarButtonItem24.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem25
            ' 
            Me.spreadsheetCommandBarButtonItem25.CommandName = "MailMergeSetGroupHeader"
            Me.spreadsheetCommandBarButtonItem25.Id = 34
            Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
            Me.spreadsheetCommandBarButtonItem25.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem26
            ' 
            Me.spreadsheetCommandBarButtonItem26.CommandName = "MailMergeSetGroupFooter"
            Me.spreadsheetCommandBarButtonItem26.Id = 35
            Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
            Me.spreadsheetCommandBarButtonItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem27
            ' 
            Me.spreadsheetCommandBarButtonItem27.CommandName = "MailMergeSetFilter"
            Me.spreadsheetCommandBarButtonItem27.Id = 36
            Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
            Me.spreadsheetCommandBarButtonItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem28
            ' 
            Me.spreadsheetCommandBarButtonItem28.CommandName = "MailMergeResetFilter"
            Me.spreadsheetCommandBarButtonItem28.Id = 37
            Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
            Me.spreadsheetCommandBarButtonItem28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarCheckItem6
            ' 
            Me.spreadsheetCommandBarCheckItem6.CommandName = "MailMergeShowRanges"
            Me.spreadsheetCommandBarCheckItem6.Id = 38
            Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
            Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem29
            ' 
            Me.spreadsheetCommandBarButtonItem29.CommandName = "MailMergePreview"
            Me.spreadsheetCommandBarButtonItem29.Id = 39
            Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
            Me.spreadsheetCommandBarButtonItem29.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' barCheckCustomValidationService
            ' 
            Me.barCheckCustomValidationService.Caption = "Custom Validation Service"
            Me.barCheckCustomValidationService.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText
            Me.barCheckCustomValidationService.Id = 40
            Me.barCheckCustomValidationService.Name = "barCheckCustomValidationService"
            ' 
            ' barBtnLoadTemplate
            ' 
            Me.barBtnLoadTemplate.Caption = "Load Template"
            Me.barBtnLoadTemplate.Id = 41
            Me.barBtnLoadTemplate.ImageOptions.Image = (CType(resources.GetObject("barBtnLoadTemplate.ImageOptions.Image"), System.Drawing.Image))
            Me.barBtnLoadTemplate.Name = "barBtnLoadTemplate"
            Me.barBtnLoadTemplate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1, Me.infoRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' infoRibbonPageGroup1
            ' 
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.infoRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.infoRibbonPageGroup1.Name = "infoRibbonPageGroup1"
            ' 
            ' mailMergeRibbonPage1
            ' 
            Me.mailMergeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.mailMergeDataRibbonPageGroup1, Me.mailMergeModeRibbonPageGroup1, Me.mailMergeExtendedRibbonPageGroup1, Me.mailMergeGroupingRibbonPageGroup1, Me.mailMergeFilteringRibbonPageGroup1, Me.mailMergeBindingRibbonPageGroup1, Me.ribbonPageGroup1})
            Me.mailMergeRibbonPage1.Name = "mailMergeRibbonPage1"
            ' 
            ' mailMergeDataRibbonPageGroup1
            ' 
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem1)
            Me.mailMergeDataRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem2)
            Me.mailMergeDataRibbonPageGroup1.Name = "mailMergeDataRibbonPageGroup1"
            ' 
            ' mailMergeModeRibbonPageGroup1
            ' 
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.mailMergeModeRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem3)
            Me.mailMergeModeRibbonPageGroup1.Name = "mailMergeModeRibbonPageGroup1"
            ' 
            ' mailMergeExtendedRibbonPageGroup1
            ' 
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem18)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem19)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem20)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem4)
            Me.mailMergeExtendedRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem23)
            Me.mailMergeExtendedRibbonPageGroup1.Name = "mailMergeExtendedRibbonPageGroup1"
            ' 
            ' mailMergeGroupingRibbonPageGroup1
            ' 
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem24)
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem25)
            Me.mailMergeGroupingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.mailMergeGroupingRibbonPageGroup1.Name = "mailMergeGroupingRibbonPageGroup1"
            ' 
            ' mailMergeFilteringRibbonPageGroup1
            ' 
            Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.mailMergeFilteringRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.mailMergeFilteringRibbonPageGroup1.Name = "mailMergeFilteringRibbonPageGroup1"
            ' 
            ' mailMergeBindingRibbonPageGroup1
            ' 
            Me.mailMergeBindingRibbonPageGroup1.AllowMinimize = False
            Me.mailMergeBindingRibbonPageGroup1.AllowTextClipping = False
            Me.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.mailMergeBindingRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.mailMergeBindingRibbonPageGroup1.Name = "mailMergeBindingRibbonPageGroup1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowMinimize = False
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barBtnLoadTemplate)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckCustomValidationService)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Validation Service"
            ' 
            ' spreadsheetFormulaBarControl1
            ' 
            Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
            Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(427, 20)
            Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBarControl1.TabIndex = 0
            ' 
            ' spreadsheetNameBoxControl1
            ' 
            Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetNameBoxControl1.EditValue = "A1"
            Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
            Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 20)
            Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetNameBoxControl1.TabIndex = 0
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 146)
            Me.splitContainerControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
            Me.splitContainerControl1.Size = New System.Drawing.Size(584, 20)
            Me.splitContainerControl1.SplitterPosition = 145
            Me.splitContainerControl1.TabIndex = 2
            ' 
            ' splitterControl1
            ' 
            Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitterControl1.Location = New System.Drawing.Point(0, 166)
            Me.splitterControl1.MinSize = 20
            Me.splitterControl1.Name = "splitterControl1"
            Me.splitterControl1.Size = New System.Drawing.Size(584, 12)
            Me.splitterControl1.TabIndex = 1
            Me.splitterControl1.TabStop = False
            ' 
            ' spreadsheetBarController1
            ' 
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
            ' 
            ' spreadsheetDockManager1
            ' 
            Me.spreadsheetDockManager1.Form = Me
            Me.spreadsheetDockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
            Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.fieldListDockPanel1)
            Me.panelContainer1.Controls.Add(Me.mailMergeParametersDockPanel1)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("64e7b2c9-a1e7-4e61-829d-5107ddf6e5cb")
            Me.panelContainer1.Location = New System.Drawing.Point(584, 146)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(200, 415)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("0f5d80bd-4e77-4bc3-b61b-ace9e17d213c")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 208)
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 208)
            Me.fieldListDockPanel1.SpreadsheetControl = Me.spreadsheetControl1
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(5, 38)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(191, 165)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' mailMergeParametersDockPanel1
            ' 
            Me.mailMergeParametersDockPanel1.Controls.Add(Me.mailMergeParametersDockPanel1_Container)
            Me.mailMergeParametersDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.mailMergeParametersDockPanel1.ID = New System.Guid("fd86f7a0-5de1-4de6-a541-699759026df5")
            Me.mailMergeParametersDockPanel1.Location = New System.Drawing.Point(0, 208)
            Me.mailMergeParametersDockPanel1.Name = "mailMergeParametersDockPanel1"
            Me.mailMergeParametersDockPanel1.OriginalSize = New System.Drawing.Size(200, 207)
            Me.mailMergeParametersDockPanel1.Size = New System.Drawing.Size(200, 207)
            Me.mailMergeParametersDockPanel1.SpreadsheetControl = Me.spreadsheetControl1
            ' 
            ' mailMergeParametersDockPanel1_Container
            ' 
            Me.mailMergeParametersDockPanel1_Container.Location = New System.Drawing.Point(5, 38)
            Me.mailMergeParametersDockPanel1_Container.Name = "mailMergeParametersDockPanel1_Container"
            Me.mailMergeParametersDockPanel1_Container.Size = New System.Drawing.Size(191, 165)
            Me.mailMergeParametersDockPanel1_Container.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.spreadsheetControl1)
            Me.Controls.Add(Me.splitterControl1)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.panelContainer1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Form1"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelContainer1.ResumeLayout(False)
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.mailMergeParametersDockPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private spreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarSubItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarCheckItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private fileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
        Private infoRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.InfoRibbonPageGroup
        Private mailMergeRibbonPage1 As DevExpress.XtraSpreadsheet.UI.MailMergeRibbonPage
        Private mailMergeDataRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeDataRibbonPageGroup
        Private mailMergeModeRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeModeRibbonPageGroup
        Private mailMergeExtendedRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeExtendedRibbonPageGroup
        Private mailMergeGroupingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeGroupingRibbonPageGroup
        Private mailMergeFilteringRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeFilteringRibbonPageGroup
        Private mailMergeBindingRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.MailMergeBindingRibbonPageGroup
        Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
        Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
        Private spreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
        Private spreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager
        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
        Private fieldListDockPanel1 As DevExpress.XtraSpreadsheet.FieldListDockPanel
        Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private mailMergeParametersDockPanel1 As DevExpress.XtraSpreadsheet.MailMergeParametersDockPanel
        Private mailMergeParametersDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private WithEvents barCheckCustomValidationService As DevExpress.XtraBars.BarCheckItem
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents barBtnLoadTemplate As DevExpress.XtraBars.BarButtonItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

