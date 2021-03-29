using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Supplier
{
    public class SuppliersPage : SubPage<SupplierPage>
    {
        public SuppliersPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.SupplierList>();

        }
    }
}
