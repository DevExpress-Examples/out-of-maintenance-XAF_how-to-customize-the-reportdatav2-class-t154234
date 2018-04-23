namespace CustomizeReportDataExample.Win {
    partial class CustomizeReportDataExampleWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.reportsModuleV21 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.scriptRecorderWindowsFormsModule1 = new DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule();
            this.scriptRecorderModuleBase1 = new DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase();
            this.module3 = new CustomizeReportDataExample.Module.CustomizeReportDataExampleModule();
            this.module4 = new CustomizeReportDataExample.Module.Win.CustomizeReportDataExampleWindowsFormsModule();
            this.reportsWindowsFormsModuleV21 = new DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // reportsModuleV21
            // 
            this.reportsModuleV21.EnableInplaceReports = true;
            this.reportsModuleV21.ReportDataType = typeof(CustomizeReportDataExample.Module.BusinessObjects.MyReportDataV2);
            // 
            // CustomizeReportDataExampleWindowsFormsApplication
            // 
            this.ApplicationName = "CustomizeReportDataExample";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.reportsModuleV21);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.scriptRecorderModuleBase1);
            this.Modules.Add(this.scriptRecorderWindowsFormsModule1);
            this.Modules.Add(this.reportsWindowsFormsModuleV21);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomizeReportDataExampleWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.CustomizeReportDataExampleWindowsFormsApplication_CustomizeLanguagesList);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private CustomizeReportDataExample.Module.CustomizeReportDataExampleModule module3;
        private CustomizeReportDataExample.Module.Win.CustomizeReportDataExampleWindowsFormsModule module4;
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV21;
        private DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule scriptRecorderWindowsFormsModule1;
        private DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase scriptRecorderModuleBase1;
        private DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2 reportsWindowsFormsModuleV21;
    }
}
