using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace CoalStore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions, ImageName("BO_Task")]
    public interface IStore
    {
        int id { get; set; }
        String Name { get; set; }
        IList<IArea> Areas { get; }
    }
}
