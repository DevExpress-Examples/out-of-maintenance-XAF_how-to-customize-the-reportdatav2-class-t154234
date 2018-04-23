#Application CustomizeReportDataExample.Win
#Application CustomizeReportDataExample.Web


*Action Navigation(Reports.Reports)

*CheckTable
 Columns = Category, Display Name
 Row = Predefined, Contacts Report

#IfDef CustomizeReportDataExample.Win
*Action New(Report)

*FillForm
 Display Name = Test Report
 Data Type = Contact
 Category = Test

*Action Cancel
#EndIf



