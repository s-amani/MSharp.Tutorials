using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Product
{
    public class ViewPage : SubPage<ProductPage>
    {
        public ViewPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductView>();
        }
    }
}
