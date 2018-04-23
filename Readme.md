#  How to validate the ObjectDataSource contained in the Spreadsheet MailMerge template


This example illustrates how to use the <a href="http://help.devexpress.com/#WindowsForms/DevExpressXtraSpreadsheetSpreadsheetControlOptions_DataSourceOptionstopic">SpreadsheetControl.Options.DataSourceOptions</a> property and a custom service that implements the <a href="http://help.devexpress.com/#CoreLibraries/clsDevExpressXtraSpreadsheetServicesIObjectDataSourceValidationServicetopic">IObjectDataSourceValidationService</a> interface to validate an <a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessObjectBindingObjectDataSourcetopic">ObjectDataSource</a> contained in the loaded <a href="http://help.devexpress.com/#WindowsForms/CustomDocument17018">mail merge template </a>and prevent the data source from loading.<br>Click <strong>Load Template </strong>to load mail merge template with object data source. Check the <strong>Custom Validation Service </strong>checkbox to replace a default service with a custom implementation which silently prohibits data loading.<br><br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-validate-the-objectdatasource-contained-in-the-spreadsheet-mailmerge-template-t514794/16.2.7+/media/242377f7-3ba2-11e7-80c0-00155d624807.png"><br><br>

<br/>


