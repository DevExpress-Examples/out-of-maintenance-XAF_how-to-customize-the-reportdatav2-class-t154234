using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using CustomizeReportDataExample.Module.BusinessObjects;

namespace CustomizeReportDataExample.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (ObjectSpace.GetObjectsCount(typeof(Contact), null) == 0) {
                Contact mary = ObjectSpace.CreateObject<Contact>();
                mary.Name = "Mary";
                mary.Email = "mary@example.com";
                Contact john = ObjectSpace.CreateObject<Contact>();
                john.Name = "John";
                john.Email = "john@example.com";
            }
            foreach (MyReportDataV2 reportData in ObjectSpace.GetObjects<MyReportDataV2>()) {
                if ((reportData.IsPredefined) && string.IsNullOrEmpty(reportData.Category)) {
                    reportData.Category = "Predefined";
                }
            }
        }
        public override void UpdateDatabaseBeforeUpdateSchema() {
            base.UpdateDatabaseBeforeUpdateSchema();
            //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            //}
        }
    }
}
