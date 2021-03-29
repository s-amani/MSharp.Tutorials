using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Supplier
{
    public class EditPage : SubPage<SupplierPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.SupplierEdit>();
        }
    }
}