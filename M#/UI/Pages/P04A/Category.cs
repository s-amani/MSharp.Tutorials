using System;
using System.Collections.Generic;
using System.Text;
using MSharp;


public class CategoryPage : RootPage
{
    public CategoryPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<P04A.Category.CategoriesPage>());
    }
}

