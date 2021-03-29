using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Supplier
{
    public class EnterPage : SubPage<SupplierPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.SupplierAdd>();
        }
    }
}
