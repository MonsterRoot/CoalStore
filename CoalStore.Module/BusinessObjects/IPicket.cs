using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace CoalStore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions, ImageName("BO_Task")]
    public interface IPicket
    {
        int id { get; set; }
        int Num { get; set; }
        string Weight { get; set; }
        int AreaId { get; set; }
    }
}
