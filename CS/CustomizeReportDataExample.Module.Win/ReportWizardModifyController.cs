using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2.Win;
using CustomizeReportDataExample.Module.BusinessObjects;


namespace CustomizeReportDataExample.Module.Win {
    public class ReportWizardModifyController : ViewController {
        WinReportServiceController reportServiceController;
        public ReportWizardModifyController() { }
        protected override void OnActivated() {
            base.OnActivated();
            reportServiceController = Frame.GetController<WinReportServiceController>();
            reportServiceController.NewXafReportWizardShowing +=
                reportServiceController_NewXafReportWizardShowing;
        }
        protected override void OnDeactivated() {
            reportServiceController.NewXafReportWizardShowing -=
                reportServiceController_NewXafReportWizardShowing;
            reportServiceController = null;
            base.OnDeactivated();
        }
        void reportServiceController_NewXafReportWizardShowing(object sender,
            NewXafReportWizardShowingEventArgs e) {
            if (!e.ReportDataType.Equals(typeof(MyReportDataV2))) return;
            CustomReportWizardParameters newReportParamsObject = new
                CustomReportWizardParameters(e.WizardParameters.Report, e.WizardParameters.ReportDataType);
            newReportParamsObject.Category = "Default";
            e.WizardParameters = newReportParamsObject;
        }
    }
}
