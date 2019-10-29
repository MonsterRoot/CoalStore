using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;


namespace CoalStore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions]
    public interface IArea 
    {
        //String Title { get; }
        UInt32 Weight { get; set; }
        IList<IPicket> Pickets { get; }
    }
}