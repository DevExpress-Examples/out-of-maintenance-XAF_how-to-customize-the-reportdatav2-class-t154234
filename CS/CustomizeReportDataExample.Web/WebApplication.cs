using System;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.Web;
using System.Collections.Generic;
using DevExpress.ExpressApp.Xpo;

namespace CustomizeReportDataExample.Web {
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    public partial class CustomizeReportDataExampleAspNetApplication : WebApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule module2;
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV21;
        private DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2 reportsAspNetModuleV21;
        private CustomizeReportDataExample.Module.CustomizeReportDataExampleModule module3;
        
        public CustomizeReportDataExampleAspNetApplication() {
            InitializeComponent();
        }
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
        }
        private void CustomizeReportDataExampleAspNetApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
            e.Updater.Update();
            e.Handled = true;
        }
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule();
            this.reportsModuleV21 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.module3 = new CustomizeReportDataExample.Module.CustomizeReportDataExampleModule();
            this.reportsAspNetModuleV21 = new DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // reportsModuleV21
            // 
            this.reportsModuleV21.EnableInplaceReports = true;
            this.reportsModuleV21.ReportDataType = typeof(CustomizeReportDataExample.Module.BusinessObjects.MyReportDataV2);
            // 
            // CustomizeReportDataExampleAspNetApplication
            // 
            this.ApplicationName = "CustomizeReportDataExample";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.reportsModuleV21);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.reportsAspNetModuleV21);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomizeReportDataExampleAspNetApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
