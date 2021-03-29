using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Product
{
    public class EnterPage : SubPage<ProductPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductAdd>();
        }
    }
}
