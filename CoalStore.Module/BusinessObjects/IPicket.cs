using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;


namespace CoalStore.Module.BusinessObjects
{
    [DomainComponent, DefaultClassOptions]
    public interface IPicket 
    {
        int Num { get; set; }

    }
}