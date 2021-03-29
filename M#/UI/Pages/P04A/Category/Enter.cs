using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Category
{
    public class EnterPage : SubPage<CategoryPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CategoryAdd>();
        }
    }
}
