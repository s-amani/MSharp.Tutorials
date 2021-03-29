using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace P04A.Category
{
    public class EditPage : SubPage<CategoryPage>
    {
        public EditPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CategoryEdit>();
        }
    }
}