using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace CustomizeReportDataExample.Module.BusinessObjects {
    [DefaultClassOptions, ImageName("BO_Contact")]
    public class Contact : BaseObject {
        public Contact(Session session) : base(session) { }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
