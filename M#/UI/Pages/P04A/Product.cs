using System;
using System.Collections.Generic;
using System.Text;
using MSharp;


public class ProductPage : RootPage
{
    public ProductPage()
    {
        Add<Modules.MainMenu>();

        OnStart(x => x.Go<P04A.Product.ProductsPage>());
    }
}

