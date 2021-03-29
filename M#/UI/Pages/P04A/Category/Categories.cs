using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Category
{
    public class CategoriesPage : SubPage<CategoryPage>
    {
        public CategoriesPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CategoryList>();

        }
    }
}
