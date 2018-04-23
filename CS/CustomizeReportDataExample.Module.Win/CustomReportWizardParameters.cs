using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.ReportsV2.Win;
using DevExpress.XtraReports.UI;
using CustomizeReportDataExample.Module.BusinessObjects;


namespace CustomizeReportDataExample.Module.Win {
    [DomainComponent]
    public class CustomReportWizardParameters : NewReportWizardParameters {
        public CustomReportWizardParameters(XtraReport report, Type reportDataType) :
            base(report, reportDataType) { }
        public string Category { get; set; }
        public override void AssignData(IReportDataV2Writable reportData) {
            base.AssignData(reportData);
            if (reportData is MyReportDataV2) {
                ((MyReportDataV2)reportData).Category = Category;
            }
        }
    }
}
