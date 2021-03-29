using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Product
{
    public class EditPage : SubPage<ProductPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductEdit>();
        }
    }
}