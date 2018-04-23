using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ReportsV2.Web;
using CustomizeReportDataExample.Module.BusinessObjects;

namespace CustomizeReportDataExample.Module.Web {
    public class ReportWizardModifyController : ViewController {
        WebReportServiceController reportServiceController;
        public ReportWizardModifyController() { }
        protected override void OnActivated() {
            base.OnActivated();
            reportServiceController = Frame.GetController<WebReportServiceController>();
            reportServiceController.NewReportWizardShowing +=
                reportServiceController_NewReportWizardShowing;
        }
        protected override void OnDeactivated() {
            reportServiceController.NewReportWizardShowing -=
                reportServiceController_NewReportWizardShowing;
            reportServiceController = null;
            base.OnDeactivated();
        }
        void reportServiceController_NewReportWizardShowing(object sender,
            WebNewReportWizardShowingEventArgs e) {
            if (!e.ReportDataType.Equals(typeof(MyReportDataV2))) return;
            CustomReportWizardParameters newReportParamsObject = new
                CustomReportWizardParameters(e.WizardParameters.Report, e.WizardParameters.ReportDataType);
            newReportParamsObject.Category = "Default";
            e.WizardParameters = newReportParamsObject;
        }
    }
}
