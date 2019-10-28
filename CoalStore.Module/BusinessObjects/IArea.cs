using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;

namespace CoalStore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions, ImageName("BO_Task")]
    public interface IArea
    {
        int id { get; set; }
        string Name { get; set; }
        IList<IPicket> Pickets { get; }
    }
 }
