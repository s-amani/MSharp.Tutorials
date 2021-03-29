using System;
using System.Collections.Generic;
using System.Text;
using MSharp;


public class SupplierPage : RootPage
{
    public SupplierPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<P04A.Supplier.SuppliersPage>());
    }
}

