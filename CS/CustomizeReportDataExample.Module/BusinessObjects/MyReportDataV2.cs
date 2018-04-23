using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace CustomizeReportDataExample.Module.BusinessObjects {
    public class MyReportDataV2 : DevExpress.Persistent.BaseImpl.ReportDataV2 {
        public MyReportDataV2(Session session) : base(session) { }
        private string category;
        public string Category {
            get { return category; }
            set { SetPropertyValue("Category", ref category, value); }
        }
    }
}
