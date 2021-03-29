using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Product
{
    public class ProductsPage : SubPage<ProductPage>
    {
        public ProductsPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.ProductList>();

        }
    }
}
